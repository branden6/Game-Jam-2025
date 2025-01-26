using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;  // Example health value

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Destroy(gameObject); // Destroy the enemy when health is 0
        }
    }
}
