using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBlastController : MonoBehaviour
{
    public float bulletSpeed;
    public float timeToLive;
    public GameObject hitEffect;

    Vector3 moveVector;


    private void Start()
    {
        moveVector = Vector3.up * bulletSpeed * Time.fixedDeltaTime;
        StartCoroutine(DestroyBlast());
    }

    private void FixedUpdate()
    {
        transform.Translate(moveVector);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }

    IEnumerator DestroyBlast()
    {
        yield return new WaitForSeconds(timeToLive);
        Destroy(gameObject);
    }
}
