using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe_throw : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firePoint;
    public GameObject axePrefab;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        if(player.axeActive == true)
        {
            Instantiate(axePrefab, firePoint.position, firePoint.rotation);
        }
        
    }
}
