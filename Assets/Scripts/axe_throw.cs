using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe_throw : MonoBehaviour
{
    public Transform firePoint;
    public GameObject axePrefab;
    public Player player;

    //Check for input and throw axe
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    //checks if and where to throw the axe
    void shoot()
    {
        if(player.axeActive == true)
        {
            Instantiate(axePrefab, firePoint.position, firePoint.rotation);
        }
        
    }
}
