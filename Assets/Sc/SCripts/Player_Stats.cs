using UnityEngine;

[CreateAssetMenu(fileName = "Player_Stats", menuName = "Scriptable Objects/Player_Stats")]
public class Player_Stats : ScriptableObject
{
    public int Currency = 0;

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

    public void set_Currency(int x)
    {
        if (x < 0)
        {
            Currency = 0;
        }
    }

    public int get_Currency()
    {
        return Currency;
    }

    public void reset()
    {
        Currency = 0;
    }
}
