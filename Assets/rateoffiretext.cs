using TMPro;
using UnityEngine;

public class rateoffiretext : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Player_Stats stats;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Upgarde Rate of Fire: {0}", stats.fireRate);
    }
}
