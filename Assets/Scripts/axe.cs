using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Physics for axe
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //Check for collision and hurt the boss and destroy axe 
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Master master = hitInfo.GetComponent<Master>();
        if (master != null)
        {
            master.Hurt();
        }
        Destroy(gameObject);
    }
}
