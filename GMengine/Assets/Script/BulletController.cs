using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x < -100.0f || transform.position.x > 100.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Shoot(float speed)
    {
        this.GetComponent<Rigidbody>().velocity = this.transform.forward * speed;
    }

    private void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "ENEMY")
        {
            coll.gameObject.GetComponent<ParticleSystem>().Play();
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<ScoreManager>().IncScore();
            GameObject enemyGenerator = GameObject.Find("EnemyGenerator");
            enemyGenerator.GetComponent<EnemyGenerator>().makeEmeny();
            Destroy(gameObject, 0.2f);
            Destroy(coll.gameObject);
        }

        if(coll.collider.tag == "DEATHZONE")
        {
            Destroy(gameObject);
        }
    }
}
