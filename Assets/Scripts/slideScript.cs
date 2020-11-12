using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideScript : MonoBehaviour
{
    private Rigidbody rb;
    public Animator animator;
    public playerController playerScript;
    public jumpScript jumpingScript;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScript = GameObject.Find("Player").GetComponent<playerController>();
        jumpingScript = GameObject.Find("Player").GetComponent<jumpScript>();
    }


    void Update()
    {
            
        if (Input.GetKeyDown(KeyCode.LeftControl) && jumpingScript.isGrounded)
        {
            jumpingScript.isAction = true;
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
            jumpingScript.isGrounded = false;
            animator.SetTrigger("slide");
            StartCoroutine(slidewait());
        }
    }
   
    IEnumerator slidewait()
    {
        yield return new WaitForSeconds(0.8f);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        jumpingScript.isAction = false;
    }
}
