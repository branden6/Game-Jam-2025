using TMPro;
using UnityEngine;

public class HealthDisp : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player_Stats stats;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Upgarde Health: {0}", stats.health);
    }
}
