using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public Camera myCam;

    private Vector3 movement;
    private Rigidbody rb;
    private float speedEQ;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        //turning
        movement = new Vector3(hor, 0, ver);
        movement = myCam.transform.TransformDirection(movement);

        if((hor > 0.1f || ver > 0.1f) || (hor < -0.1f || ver < -0.1f) ) 
        {
           var rotation = Quaternion.LookRotation(new Vector3(movement.x, 0, movement.z)); 
           transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
        }
        
        //Moving
        rb.velocity = new Vector3(movement.x * Speed, rb.velocity.y, movement.z * Speed);
    }
}
