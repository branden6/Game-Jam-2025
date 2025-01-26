using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player_Stats stats;
    void Start()
    {
        
    }
    public void StartGame()
    {
        stats.reset();
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        stats.reset();
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
