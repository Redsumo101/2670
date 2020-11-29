using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   
    public GameObject[] enemyPrefabs;
    public Vector3[] spawnPoints;
    public float repeatRate = 2.0f;
    public GameObject wall;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InvokeRepeating("EnemySpawn", 0.5f, repeatRate);
            Destroy(gameObject, 20);
            Destroy(wall, 20);
            
            
        }
    }

     void EnemySpawn()
    {
        int enemyIndex = Random.Range(0, 3);
        int spawnIndex = Random.Range(0, 7);
        Instantiate(enemyPrefabs[enemyIndex], spawnPoints[spawnIndex], enemyPrefabs[enemyIndex].transform.rotation);
    }
}
