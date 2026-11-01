using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;

    public float spawnTime = 2f;
    public float minX = -7f;
    public float maxX = 7f;

    void Start()
    {
        InvokeRepeating("SpawnApple", 1f, spawnTime);
    }

    void SpawnApple()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 spawnPosition = new Vector3(randomX, 5f, 0f);

        Instantiate(applePrefab, spawnPosition, Quaternion.identity);
    }
}