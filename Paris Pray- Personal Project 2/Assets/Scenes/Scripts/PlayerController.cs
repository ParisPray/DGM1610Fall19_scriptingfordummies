using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce;
    public float gravityModifier;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 30.0f;
    public bool isOnGround = true;
    public bool gameOver = false;
    public bool hasPowerup;
    public ParticleSystem explosionParticle;
    public ParticleSystem sparkleParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip dragonSound;
    public AudioClip coinSound;
    private AudioSource playerAudio;
    public GameObject powerupIndicator;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score;
    public Button restartButton;
    public GameObject titleScreen;
    private Button startButton;


    // Start is called before the first frame update
    public void Start()
    {
        // Player rigidbody and physics
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        score = 0;
        scoreText.text = "Score: " + score;
        UpdateScore(0);
        


    }

    // Update is called once per frame
    void Update()
    {
        // Player is kept within bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (!gameOver)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }

        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        // Player can jump, but only once

        if ((Input.GetKeyDown(KeyCode.Space)) && isOnGround && !gameOver)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Treasure"))
        {
            
            Destroy(other.gameObject);
            UpdateScore(10);
            sparkleParticle.Play();
            playerAudio.PlayOneShot(coinSound, 1.0f);
        }
    }

    // Game Over on the event of obstacle collision


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            playerAudio.PlayOneShot(dragonSound, 1.0f);
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            titleScreen.gameObject.SetActive(true);
        }

    }
    

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    
 

}
