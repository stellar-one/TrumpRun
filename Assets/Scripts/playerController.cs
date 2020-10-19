using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float runSpeed;
    public float strafeSpeed;
    public bool foward;
    public bool back;
    public bool left;
    public bool right;
    public Transform L_lane;
    public Transform M_lane;
    public Transform R_lane;

    public void Update()
    {
        if (foward)
        {
            this.gameObject.transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
            Debug.Log("Foward");

            if (Input.GetKey(KeyCode.A))
            {
                this.gameObject.transform.Translate(Vector3.left * strafeSpeed * Time.deltaTime);
                Debug.Log("Left");
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.gameObject.transform.Translate(Vector3.right * strafeSpeed * Time.deltaTime);
                Debug.Log("Left");
            }
        }


        if (back)
        {
            this.gameObject.transform.Translate(Vector3.back * runSpeed * Time.deltaTime);
            Debug.Log("Back");
        }
        if (left)
        {
            this.gameObject.transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
            Debug.Log("Left");
        }
        if (right)
        {
            this.gameObject.transform.Translate(Vector3.right * runSpeed * Time.deltaTime);
            Debug.Log("Right");
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.left * runSpeed * Time.deltaTime);
            Debug.Log("Left");
        }











    }
  
}
