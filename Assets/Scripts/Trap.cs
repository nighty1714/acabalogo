using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    
    public GameObject enemy;
    GameObject player;
    List<GameObject> enemysAlive;
    public int maxEnemies = 5;
    public float x = 0;
    public float z = 0;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemysAlive = new List<GameObject>();
    }

    private void OnTriggerEnter(){
        if(enemysAlive.Count < maxEnemies){
            Vector3 enemyPosition = new Vector3(x, 
            player.transform.position.y, z);
            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);
            enemysAlive.Add(newEnemy);
        }
    }
}
