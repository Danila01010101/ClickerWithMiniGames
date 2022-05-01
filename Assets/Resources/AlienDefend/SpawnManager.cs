using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] monsterPrefabs;
    [SerializeField] private GameObject coinPrefabs;
    [SerializeField] private GameObject heartPrefabs;
    [SerializeField] private float startDelayCoin = 20f;
    [SerializeField] private float spawnIntervalCoin = 10f;
    [SerializeField] private float startDelayHeart = 30f;
    [SerializeField] private float spawnIntervalHeart = 15f;

    private float startDelay = 2f;
    private float spawnInterval = 1f;


    void Start()
    {
        InvokeRepeating("SpawnRandomMonsters", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomCoins", startDelayCoin, spawnIntervalCoin);
        InvokeRepeating("SpawnRandomHearts", startDelayHeart, spawnIntervalHeart);
    }

    void SpawnRandomMonsters()
    {
        int monsterIndex = Random.Range(0, monsterPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-25, -21), 0.15f, Random.Range(-10, 11));
        Instantiate(monsterPrefabs[monsterIndex], spawnPos, monsterPrefabs[monsterIndex].transform.rotation);
    }

    void SpawnRandomCoins()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-25, -15), 3f, Random.Range(-10, 11));
        Instantiate(coinPrefabs, spawnPos, coinPrefabs.transform.rotation);
    }

    void SpawnRandomHearts()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-25, -15), 3f, Random.Range(-10, 11));
        Instantiate(heartPrefabs, spawnPos, heartPrefabs.transform.rotation);
    }
}