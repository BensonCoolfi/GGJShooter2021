using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject laserBlastPrefab;
    public Transform BulletSpawn;
    public Renderer rend;
    public float timeBetweenShots;
    public float timeOfFlash = 0.1f;
    private bool canShoot;
  
    private void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && canShoot && GameManager.instance.gamePlaying)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        canShoot = false;
        Instantiate(laserBlastPrefab, BulletSpawn.position, transform.rotation);
        rend.enabled = true;
        StartCoroutine(ShotCooldown());
    }

    IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(timeOfFlash);
        rend.enabled = false;
        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
    }
}

