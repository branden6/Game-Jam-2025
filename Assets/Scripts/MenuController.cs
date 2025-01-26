using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject[] pauseUI; //index 0; button , index1; panel
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }
   
    //pause game
    public void pause()
    {
        Time.timeScale = 0;
        pauseUI[0].SetActive(false);
        pauseUI[1].SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    //unPause Game
    public void unPause()
    {
        Time.timeScale = 1;
        pauseUI[0].SetActive(true);
        pauseUI[1].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
