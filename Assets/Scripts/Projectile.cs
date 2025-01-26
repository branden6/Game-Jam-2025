using UnityEngine;


using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float destroyAfterSeconds =  10f; // Auto-destroy after 10 seconds

    private void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile hit something: " + collision.transform.name);  // Log when the projectile hits something

        if (collision.transform.CompareTag("Enemy"))
        {
            Debug.Log("Hit Enemy");
            Destroy(collision.gameObject); // Destroy the enemy on hit
            Destroy(gameObject); // Destroy the projectile
        }
        else
        {
            //Destroy(gameObject); // Destroy the projectile if it hits anything else
        }
    }
}
