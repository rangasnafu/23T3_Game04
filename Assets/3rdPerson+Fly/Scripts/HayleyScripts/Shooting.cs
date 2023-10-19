using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float shootInterval;
    private float shootTimer;

    //public AudioClip shootSound;
    //private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateShooting();

    }

    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0 && Input.GetKey(KeyCode.Mouse0))
        {
            shootTimer = shootInterval;
            ShootBullet();

        }
    }

    private void ShootBullet()
    {
        //audioSource.PlayOneShot(shootSound);
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        //instantiate means to spawn, quaternion means rotation
    }
}
