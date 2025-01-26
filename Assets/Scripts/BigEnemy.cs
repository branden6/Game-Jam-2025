using UnityEngine;

public class BigEnemy : MonoBehaviour
{
    public float health = 200f;  // Example health value

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Destroy(gameObject); // Destroy the big enemy when health is 0
        }
    }
}

