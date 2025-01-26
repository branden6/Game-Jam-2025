using UnityEngine;


using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float destroyAfterSeconds = 10f; // Auto-destroy after 10 seconds
    public float damageAmount = 10f; // Amount of damage dealt by the projectile
    public Player_Stats stats;

    private void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile hit something: " + collision.transform.name);  // Log when the projectile hits something

        // Check if the object hit has the "Enemy" tag
        if (collision.transform.CompareTag("Enemy"))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageAmount); // Call TakeDamage method to decrease health
            }
            stats.Currency += 2;
            Destroy(gameObject); // Destroy the projectile
        }
        // Check if the object hit has the "BigEnemy" tag
        else if (collision.transform.CompareTag("BigEnemy"))
        {
            BigEnemy bigEnemy = collision.gameObject.GetComponent<BigEnemy>();
            if (bigEnemy != null)
            {
                bigEnemy.TakeDamage(damageAmount); // Call TakeDamage method to decrease health
            }
            stats.Currency += 3;
            Destroy(gameObject); // Destroy the projectile
        }
        else
        {
            // You can handle other collision cases here, if necessary
            Destroy(gameObject); // Destroy the projectile if it hits something else
        }
    }
}
