using UnityEngine;

public class WaveManager : MonoBehaviour
{
   public static WaveManager Instance;
   public float amplitude = 1f;
    public float length= 2f;
    public float speed = 1f;
    public float offset = 0f;


    private void Awake() {
        if (Instance == null)   
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Debug.Log("Instance already exists, destroing object!");
            Destroy(this);
                
         }
    }


    private void Update() {
        offset += Time.deltaTime * speed;

    }
    public float GetWaveHeight(float _x) {
        return amplitude * Mathf.Sin(_x/ length + offset);
    
    }


}
