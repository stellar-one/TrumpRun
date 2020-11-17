using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Obstacle
{
    void Start(){
        this.x = 0f;
        this.y = 2f;
        this.z = Random.Range(-4.5f, 5f);
    }
}
