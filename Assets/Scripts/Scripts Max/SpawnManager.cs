using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject[] monsterPrefabs;
    private float startDelay = 2f;
    private float spawnInterval = 1f;
    void Start()
    {
        InvokeRepeating("SpawnRandomMonsters", startDelay, spawnInterval);
    }

    void SpawnRandomMonsters()
    {
        int monsterIndex = Random.Range(0, monsterPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-25, -21), 0.15f, Random.Range(-10, 11));
        Instantiate(monsterPrefabs[monsterIndex], spawnPos, monsterPrefabs[monsterIndex].transform.rotation);
    }
}