using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public float speed = 20f;
    public float vspeed = 20f;
    public Rigidbody2D rb;
    public Player playerScript;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

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
