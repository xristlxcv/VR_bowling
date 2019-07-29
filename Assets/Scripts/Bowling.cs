using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowling : MonoBehaviour
{
    private Vector3 startPosition;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
           rb.angularVelocity = Vector3.zero;
            rb.velocity = new Vector3(0, 2, 0);
            transform.position = startPosition;
            
        }
    }
}
