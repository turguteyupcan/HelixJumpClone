using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //.AddForce(Vector3.up * jumpForce);
        rb.velocity = Vector3.up * jumpForce;
        string material = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(material);
    }
}
