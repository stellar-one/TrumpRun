using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, 6, 0);
    }
}
