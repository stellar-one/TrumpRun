using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideScript : MonoBehaviour
{
    private Rigidbody rb;
    public bool isGrounded = false;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
            
        if (Input.GetKeyDown(KeyCode.LeftControl) && isGrounded)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
            isGrounded = false;
            Debug.Log("Slide");
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        { 
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
            isGrounded = true;
            Debug.Log("Stand");
        }
    }
    void OnCollisionEnter(Collision theCollision){
        if(theCollision.gameObject.tag == "Ground"){
            isGrounded = true;
        }
    }

    void OnCollisionExit(){

    }
}
