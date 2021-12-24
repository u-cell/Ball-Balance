using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balltrailscript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gerak = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        rb.AddForce(gerak * speed);
        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 at = new Vector3(0, 5, 0);
            rb.AddForce(at * speed);
        }
    }
}
