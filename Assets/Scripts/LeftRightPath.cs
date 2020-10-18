using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPath : Paths
{
    void Start(){
        float[] leftRight = {-90f, 90f};
        this.spawnPosition = new Vector3(0f, 4f, 0f);
        this.transform.Rotate(new Vector3(0f, leftRight[Random.Range(0, leftRight.Length)], 0f));
    }
}