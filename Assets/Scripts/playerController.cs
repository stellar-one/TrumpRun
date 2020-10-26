using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public float Health = 3f;
    public float runSpeed;
    public float strafeSpeed;
    public bool foward;
    public bool back;
    public bool left;
    public bool right;
    public Animator animator;
    public float coins = 0;
    public Text coinText;
    public GameObject baseMesh,heart,heart1,heart2;
    public Transform targetCam;
    private bool colidder = false;
  
   
    public void Update()
    {
        coinText.text = coins.ToString();

        if (colidder == true)
        {
            if ((Input.GetKeyDown(KeyCode.D)))
            {
                if (foward)
                {
                    Debug.Log("R_Turn");
                    foward = false;
                    right = true;
                    left = false;
                    back = false;
                    baseMesh.transform.Rotate(0, 90, 0);
                    targetCam.transform.Rotate(15, 90, -15);
                }

            }

            if ((Input.GetKeyDown(KeyCode.A)))
            {
                Debug.Log("L_Turn");
                foward = false;
                right = false;
                left = true;
                back = false;
                baseMesh.transform.Rotate(0,-90, 0);
                targetCam.transform.Rotate(15, -90, 15);
            }
        }


      
        if (foward)
        {
            this.gameObject.transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x - 8f, 6, 0);

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
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x - 8f, 6, 0);

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.left * strafeSpeed * Time.deltaTime);
            }
        }

        if (left)
        {
            this.gameObject.transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x, 6, baseMesh.transform.position.z - 8);

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.back * strafeSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.forward * strafeSpeed * Time.deltaTime);
            }
        }

        if (right)
        {
            this.gameObject.transform.Translate(Vector3.right * runSpeed * Time.deltaTime);
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x, 6, baseMesh.transform.position.z + 8);

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.forward * strafeSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.back * strafeSpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider triggered)
    {
        if (triggered.gameObject.tag == "Right Turn")
        {
            colidder = true;
        }
        if(triggered.gameObject.tag == "Enemy")
        {
            Health = Health - 1f;
            Debug.Log("hit");
            animator.SetTrigger("hit");
            heart.SetActive(false);

            if(Health == 1) 
            {
                heart1.SetActive(false);
            }
            if (Health == 0f)
            {
                heart2.SetActive(false);
            }
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

    private void OnTriggerExit(Collider triggered)
    {
        if (triggered.gameObject.tag == "Right Turn")
        {
            colidder = false;
        }
    }


  

}
