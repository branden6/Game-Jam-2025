using TMPro;
using UnityEngine;

public class getCoins : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI text;
    public Player_Stats stats;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Bubbles: {0}", stats.get_Currency());
    }
}
