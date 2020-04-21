using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickup : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks for collison with player and destroys the pickup
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            Destroy(gameObject);
        }
    }
}
