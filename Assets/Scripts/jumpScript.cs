using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{

    private Rigidbody rb;
    private BoxCollider cl;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cl = GetComponent<BoxCollider>();
    }
    public bool isGrounded = false;
    public float jumpHeight = 8f;
    public int count;
    void Update()
    {
            
        
       if(Input.GetKeyDown(KeyCode.Space) && isGrounded){  
               rb.AddForce(Vector3.up * jumpHeight);
               isGrounded = false;           
               Debug.Log("Jump"); 
        }
    }
    void OnCollisionEnter(Collision theCollision){
        if(theCollision.gameObject.tag == "Jump"){
            isGrounded = true;
        }
    }

    void OnCollisionExit(){

    }
}
