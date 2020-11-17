using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Obstacle
{
    void Start(){
        this.x = 0f;
        this.y = 2f;
        this.z = Random.Range(-6.5f, 7);
    }
}
