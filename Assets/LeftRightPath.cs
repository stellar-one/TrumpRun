using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPath : Paths
{
    void Start(){
        // this.x = 650f;
        // this.y = 4f;
        // this.z = 0f;
        float[] leftRight = {-90f, 90f};
        this.transform.Rotate(new Vector3(0f, leftRight[Random.Range(0, leftRight.Length)], 0f));
    }
}