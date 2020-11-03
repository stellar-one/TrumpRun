using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float Health = 3f;
    public float runSpeed;
    public float strafeSpeed;
    public bool foward;
    public bool back;
    public bool left;
    public bool right = true;
    public Animator animator;
    public float coins = 0;
    public Text coinText;
    public GameObject baseMesh,heart,heart1,heart2;
    public Transform targetCam;
    private bool colidder = false;
    private bool didTurn = false;
    private bool dead = false;
  
    public void Update()
    {
        coinText.text = coins.ToString();

        if (colidder == true && didTurn == false)
        {
            if ((Input.GetKeyDown(KeyCode.D))) // RIGHT
            {
                didTurn = true;
                if (foward) // Turn Right from foward
                {
                    foward = false;
                    right = true;
                    left = false;
                    back = false;
                    baseMesh.transform.Rotate(0, 90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15,180,0);
                }
                else if (right) // Turn Right from Right
                {
                    foward = false;
                    right = false;
                    left = false;
                    back = true;
                    baseMesh.transform.Rotate(0, 90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, -90, 0);


                }
                else if (left) // Turn Right from Left
                {
                    foward = true;
                    right = false;
                    left = false;
                    back = false;
                    baseMesh.transform.Rotate(0, 90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, 90, 0);
                }
                else if (back) // Turn Right from back
                {
                    foward = false;
                    right = false;
                    left = true;
                    back = false;
                    baseMesh.transform.Rotate(0, 90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, 0, 0);
                }
            }
            if ((Input.GetKeyDown(KeyCode.A))) // LEFT
            {
                didTurn = true;
                if (foward) // Turn Left from foward
                {          
                    foward = false;
                    right = false;
                    left = true;
                    back = false;
                    baseMesh.transform.Rotate(0, -90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, 0, 0);
                }
                else if (right) // Turn Left
                {                
                    foward = true;
                    right = false;
                    left = false;
                    back = false;
                    baseMesh.transform.Rotate(0, -90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, 90, 0);
                }
                else if (left) // Turn Left from Left
                {                
                    foward = false;
                    right = false;
                    left = false;
                    back = true;
                    baseMesh.transform.Rotate(0, -90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, -90, 0);
                }
               else if (back) // Turn Left from back
                {            
                    foward = false;
                    right = true;
                    left = false;
                    back = false;
                    baseMesh.transform.Rotate(0, -90, 0);
                    targetCam.transform.localRotation = Quaternion.Euler(15, 180, 0);
                }
            }
        }
        if (foward && dead == false)
        {
            this.gameObject.transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x - 8f, 6, baseMesh.transform.position.z);

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.left * strafeSpeed * Time.deltaTime);  
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime); 
            }
        }
        if (back && dead == false)
        {
            this.gameObject.transform.Translate(Vector3.back * runSpeed * Time.deltaTime);
            targetCam.transform.position = new Vector3(baseMesh.transform.position.x + 8f, 6, baseMesh.transform.position.z);


            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.left * strafeSpeed * Time.deltaTime);
            }
        }
        if (left && dead == false)
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
        if (right && dead == false)
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
        if (triggered.gameObject.tag == "Turn")
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
                dead = true;
                Debug.Log("Dead");
                animator.SetTrigger("killed"); 
                
            }
        }
        if(triggered.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(triggered.gameObject);
        }
        if(triggered.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    


    private void OnTriggerExit(Collider triggered)
    {
        if (triggered.gameObject.tag == "Turn")
        {
            colidder = false;
            didTurn = false;
        }
    }

   
}
