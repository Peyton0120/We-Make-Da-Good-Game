using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Player playerScript;

    //Physics for the cross
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //Checks for collision with player and damages player
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.Hurt();
        }
        Destroy(gameObject);
    }
}
