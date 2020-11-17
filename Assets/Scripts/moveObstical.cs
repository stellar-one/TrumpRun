using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstical : MonoBehaviour
{
    public int moveSpeed;
    public playerController playerScript;


    void Awake()
    {
        playerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.foward)
        {
            this.gameObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
          
        }
    }
}
