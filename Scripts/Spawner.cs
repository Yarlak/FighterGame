using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1f;
    public float spawnXRange = 8f;
    float nextSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Vector3 pos = new Vector3(Random.Range(-spawnXRange, spawnXRange), transform.position.y, 0f);
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        }
    }
}
