using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    private Rigidbody rb;
    float originalHeight = 3;
    public float reducedHeight;
    public float ySize;
    BoxCollider bC;




    void Start()
    {
        bC = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
        originalHeight = bC.size.y;

    }


    public bool isGrounded = false;
    public float jumpHeight = 8f;
  
    
    void Update()
    {
            
        
       if(Input.GetKeyDown(KeyCode.Space) && isGrounded){  
               rb.AddForce(Vector3.up * jumpHeight);
               isGrounded = false;           
               Debug.Log("Jump"); 
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && isGrounded)
        {
            bC.size = new Vector3(bC.size.x, ySize, bC.size.z);
            isGrounded = false;
            Debug.Log("Slide");
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            bC.size = new Vector3(bC.size.x, originalHeight, bC.size.z);
            isGrounded = true;
            Debug.Log("Stand");
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
