using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Vector3 bulletRotation;
    [SerializeField] private Transform bulletPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectilePrefab, bulletPosition.position, projectilePrefab.transform.rotation);
            bullet.transform.eulerAngles = bulletRotation;
        }
    }
}
