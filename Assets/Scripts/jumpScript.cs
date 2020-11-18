using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    private Rigidbody rb;
    public bool isGrounded = false;
    public bool isAction = false;
    public float jumpHeight = 8f;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isAction = true;
            rb.AddForce(Vector3.up * jumpHeight);
            isGrounded = false;
            animator.SetTrigger("jump");
            this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
            this.gameObject.GetComponent<SphereCollider>().enabled = true;
            StartCoroutine(jumpWait());
        }
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Ground" && !isAction)
        {
            isGrounded = true;
          
        }
    }
    IEnumerator jumpWait()
    {
        yield return new WaitForSeconds(0.65f);
        this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        this.gameObject.GetComponent<SphereCollider>().enabled = false;
        isAction = false;
    }
}
