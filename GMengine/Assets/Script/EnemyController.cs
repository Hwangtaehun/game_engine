using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    GameObject target;
    GameObject other;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        other = GameObject.Find("Block2");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 1.0f)
        {
            agent.destination = other.transform.position;
        }
        else
        {
            agent.destination = target.transform.position;
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "PLAYER")
        {
            SceneManager.LoadScene("Start");
        }

        if (coll.collider.tag == "DEATHZONE")
        {
            Destroy(gameObject);
            GameObject enemyGenerator = GameObject.Find("EnemyGenerator");
            enemyGenerator.GetComponent<EnemyGenerator>().makeEmeny();
        }
    }
}
