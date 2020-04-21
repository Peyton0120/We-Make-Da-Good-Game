using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axe : MonoBehaviour
{

    public float speed = 20f;
    public float vspeed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

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
