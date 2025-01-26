using UnityEngine;

[CreateAssetMenu(fileName = "Player_Stats", menuName = "Scriptable Objects/Player_Stats")]
public class Player_Stats : ScriptableObject
{
    public int health;
    public int Currency;
    public int Max_Currency;
    public int Max_Health;
    public float velocity;
    public float fireRate;
    public float Damage;

    public void add_Currency()
    {
        set_Currency(Currency + 1);
    }

    public void add_Currency(int x)
    {
        set_Currency(Currency + x);
    }

    public void sub_Currency()
    {
        set_Currency(Currency - 1);
    }

    public void sub_Currency(int x)
    {
        set_Currency(Currency - x);
    }

    public void set_Health(int x)
    {
        if (x < 0)
        {
            health = 0;
        }
        else if (x > Max_Health)
        {
            health = Max_Health;
        }
    }

    public void set_Currency(int x)
    {
        if (x < 0)
        {
            Currency = 0;
        }
        else if (x > Max_Currency)
        {
            Currency = Max_Currency;
        }
    }

    public int get_Health()
    {
        return health;
    }

    public int get_Currency()
    {
        return Currency;
    }
}
