using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
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
        //AddForce(Vector3.up * jumpForce);
        rb.velocity = Vector3.up * jumpForce;

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0, -0.2f, 0), Quaternion.Euler(90, 0, 0));
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(materialName);

        if(materialName == "Safe Color (Instance)")
        {

        }
        else if (materialName == "Unsafe Color (Instance)")
        {
            Debug.Log("Game over");
        }
        else if (materialName == "Last Ring (Instance)")
        {

        }
    }
}
