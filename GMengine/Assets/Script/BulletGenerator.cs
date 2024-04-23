using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    private AudioSource aud;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float speed = 200.0f;
    [SerializeField] private AudioClip shootSE;

    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.aud.PlayOneShot(this.shootSE);
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<BulletController>().Shoot(speed);
        }
    }
}
