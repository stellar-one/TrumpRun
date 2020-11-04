using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public playerController playerScript;
    public Transform target;

    public Transform startingCam;
    public Transform currentCamCenter;


    void Awake()
    {
        currentCamCenter = startingCam;
        playerScript = GameObject.Find("Player").GetComponent<playerController>();

    }




    // Update is called once per frame
    void Update()
    {

        if (currentCamCenter == null)
            Debug.Log("woops");

        if (playerScript.foward)
        {
            transform.position = new Vector3(target.position.x - 8f, 6, currentCamCenter.transform.position.z);
        }

        if (playerScript.back)
        {
            transform.position = new Vector3(currentCamCenter.position.x + 8f, 6, target.transform.position.z);
        }

        if (playerScript.left)
        {
            transform.position = new Vector3(currentCamCenter.position.x, 6, target.transform.position.z - 8);
        }

        if (playerScript.right)
        {
            transform.position = new Vector3(currentCamCenter.position.x, 6, target.transform.position.z + 8);
        }

    }

  
}