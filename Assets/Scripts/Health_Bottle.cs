using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bottle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Checks for collision with player and destroys instance
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            Destroy(gameObject);
        }
    }
}
