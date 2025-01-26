using TMPro;
using UnityEngine;

public class DamageDisplat : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player_Stats stats;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Upgarde Bubble Damage: {0}", stats.Damage);
    }
}
