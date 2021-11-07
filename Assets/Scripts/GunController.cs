using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject myBullet;
    public Canvas ReloadText;
    public float fireRate = 2f;
    public float reload = 5f;
    float reloadTimer;
    public int ammo = 20;
    float fireTimer;
    int currentAmmo;
    // Start is called before the first frame update
    void Start()
    {
        ReloadText.enabled = false;
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
            ReloadText.enabled = true;
            if(reloadTimer <= 0){
                currentAmmo = ammo;
                reloadTimer = reload;
                ReloadText.enabled = false;
            }
        }else{ 
            if(fireTimer >= fireRate){
                fireTimer = fireRate;
                if(Input.GetMouseButton(0)){
                    Instantiate(myBullet, gameObject.transform.position, gameObject.transform.rotation);
                    fireTimer = 0;
                    currentAmmo--;
                }
            }
        }

    }
}
