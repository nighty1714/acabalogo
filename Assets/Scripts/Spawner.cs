using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    GameObject player;
    List<GameObject> enemysAlive;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemysAlive = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemysAlive.Count < 10){
            Vector3 enemyPosition = new Vector3(player.transform.position.x + Random.Range(-10, 10), 
            player.transform.position.y, player.transform.position.z);
            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
            enemysAlive.Add(newEnemy);
        }
    }
}
