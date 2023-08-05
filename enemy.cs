using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float health;
    public float movementSpeed;
    public float visionDistance;
    Rigidbody rb;
    Transform player;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(transform.gameObject);
        }
        float playerDistance = (player.position - transform.position).magnitude;
        if (playerDistance <= visionDistance)
        {
            rb.velocity = (player.position - transform.position).normalized * movementSpeed;
        }
    }

}
