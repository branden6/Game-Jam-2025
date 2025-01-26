using TMPro;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class Healthadd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player_Stats stats;
    public Store_inventory inventory;

    public void onClickHealth()
    {
        stats.sub_Currency(inventory.health_potion_price);
        stats.set_Health(stats.get_Health() + 1);
    }

    public void onClickDamage()
    {
        stats.sub_Currency(inventory.damage_upgrade_price);
        stats.Damage = stats.Damage + 1;
    }

    public void onClickRateOfFire()
    {
        stats.sub_Currency(inventory.rate_of_fire__upgrade_price);
        stats.fireRate = stats.fireRate + 0.25f;
    }

    public void onClickVelocity()
    {
        stats.sub_Currency((inventory.bubble_velocity_upgrade_price));
        stats.velocity = stats.velocity + 0.25f;
    }
}
