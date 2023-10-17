using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    private float shootTimer;

    [SerializeField]
    private float shootDelay;

    void Update()
    {
        shoot();
        timer();
    }

    private void timer()
    {
        shootTimer += Time.deltaTime;
    }

    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
        }
    }
}
