using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float range = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            makeEmeny();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeEmeny()
    {
        float PosX = Random.Range(-range, range);
        transform.position = new Vector3(PosX, 1.0f, 40.0f);
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
