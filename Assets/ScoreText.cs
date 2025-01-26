using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player_Stats stats;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("Cleanliness Score: {0}", stats.get_Currency());
    }
}
