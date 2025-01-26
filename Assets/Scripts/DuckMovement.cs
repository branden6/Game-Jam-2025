using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour 
{
    public Rigidbody duckRigidbody;
    public float speed = 5.0f;
    private float horizontalInput, verticalInput;
    private Vector3 inputDirection;
    public Player_Stats stats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform respawnPoint;
    public float hp = 3f;
    void Start()
    {
        duckRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            
            Respawn();
        }
    }
    private void FixedUpdate()
    {
        wasdMovment();
    }

    private void wasdMovment()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        inputDirection = new Vector3((int)horizontalInput, 0, (int)verticalInput).normalized;

        duckRigidbody.linearVelocity = inputDirection * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp -= 1; // Decrease health by 1
            Debug.Log("HP: " + hp);

            // If health reaches 0, respawn the player
            if (hp < 1)
            {
                Respawn();
                
                hp = 3; // Reset health to full (if desired)
            }

        }
        if (collision.gameObject.CompareTag("BigEnemy"))
        {
           hp -= 1.5f; // Decrease health by 1
           Debug.Log("HP: " + hp);

           // If health reaches 0, respawn the player
           if (hp <= 1)
           {
               Respawn();
                hp = 3f; // Reset health to full (if desired)
           }

        }
    }
    void Respawn()
    {
        SceneManager.LoadScene(1);
        stats.reset();
        duckRigidbody.linearVelocity = Vector3.zero;
        duckRigidbody.angularVelocity = Vector3.zero;
        duckRigidbody.Sleep();
        transform.position = respawnPoint.position;
        Debug.Log("UPDATING TIMER");

    }
}
