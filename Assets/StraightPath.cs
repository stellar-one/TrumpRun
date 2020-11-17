using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightPath : Paths
{
    void Start(){
        // this.spawnPosition.Set(0f, 4f, 0f);
        this.spawnPosition = new Vector3(0f, 4f, 0f);
    }
}