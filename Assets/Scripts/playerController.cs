using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float Health = 3f;
    public float runSpeed;
    public float strafeSpeed;
    public bool foward;
    public bool back;
    public bool left;
    public bool right;
    public Transform L_lane;
    public Transform M_lane;
    public Transform R_lane;
    public Animator animator;
    public GameObject baseMesh;
    public float coins = 0;
    




    public void Update()
    {
        if (foward)
        {
            this.gameObject.transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.left * strafeSpeed * Time.deltaTime);
              
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime);
               
            }
        }


        if (back)
        {
            this.gameObject.transform.Translate(Vector3.back * runSpeed * Time.deltaTime);
           
        }
        if (left)
        {
            this.gameObject.transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
          
        }
        if (right)
        {
            this.gameObject.transform.Translate(Vector3.right * runSpeed * Time.deltaTime);
          
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
           
        }
    }


    private void OnTriggerEnter(Collider triggered)
    {
        if(triggered.gameObject.tag == "Enemy")
        {
            Health = Health - 1f;
            Debug.Log("hit");
            animator.SetTrigger("hit");
          

            if (Health == 0f)
            {
                Debug.Log("Dead");
                animator.SetTrigger("killed");

            }
        }

        if(triggered.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(triggered.gameObject);
        }














    }












}
