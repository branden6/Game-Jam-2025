using UnityEngine;

[CreateAssetMenu(fileName = "Store_inventory", menuName = "Scriptable Objects/Store_inventory")]
public class Store_inventory : ScriptableObject
{
    //can list out all of the objects and there prices here
    public int health_potion_price;
    public int damage_upgrade_price;
    public int rate_of_fire__upgrade_price;
    public int bubble_velocity_upgrade_price;
}
