using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Vector3 bulletRotation;
    [SerializeField] private Transform bulletPosition;
    [SerializeField] private float coolDown;

    private float lastTimeBulletSpawned;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastTimeBulletSpawned > coolDown)
        {
            GameObject bullet = Instantiate(projectilePrefab, bulletPosition.position, projectilePrefab.transform.rotation);
            bullet.transform.eulerAngles = bulletRotation;
            lastTimeBulletSpawned = Time.time;
        }
    }
}
