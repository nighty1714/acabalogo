using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    
    public GameObject enemy;
    GameObject player;
    List<GameObject> enemysAlive;
    public int maxEnemies = 5;
    int counter;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        counter = 0;
        enemysAlive = new List<GameObject>();
    }

    private void OnTriggerEnter(){
        if(enemysAlive.Count < maxEnemies){
            Vector3 enemyPosition = new Vector3(player.transform.position.x + Random.Range(5, 15), 
            player.transform.position.y, player.transform.position.z+ Random.Range(5, 15));
            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
            enemysAlive.Add(newEnemy);
        }
    }
}
