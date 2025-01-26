using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float minimumSpawnTime = 1.0f;
    [SerializeField] private float maximumSpawnTime = 3.0f;
    private float timeUntilNextSpawn;
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilNextSpawn -= Time.deltaTime;
        if(timeUntilNextSpawn <= 0){
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }
    private void SetTimeUntilSpawn(){
        timeUntilNextSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
    }
}
