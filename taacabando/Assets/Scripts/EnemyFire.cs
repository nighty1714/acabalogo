using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.25f;
    public float reload = 0.5f;
    float reloadTimer;
    public int ammo = 10;
    float fireTimer;
    int currentAmmo;
    // Start is called before the first frame update
    void Start()
    {
        fireTimer = fireRate;
        currentAmmo = ammo;
        reloadTimer = reload;
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        
        if(currentAmmo <= 0){
            reloadTimer -= Time.deltaTime;
            Debug.Log(reloadTimer);
            if(reloadTimer <= 0){
                currentAmmo = ammo;
                reloadTimer = reload;
            }
        }else{ 
            if(fireTimer >= fireRate){
                Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
                fireTimer = 0;
                currentAmmo--;
            }
        }
    }
}
