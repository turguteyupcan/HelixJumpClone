using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm=GameObject.FindObjectOfType<GameManager>();
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

        if (materialName == "Unsafe Color (Instance)")
        {
            gm.RestartGame();
        }
        else if (materialName == "LastRing (Instance)")
        {
            Debug.Log("Next Level");
            gm.Win();
        }
    }
}
