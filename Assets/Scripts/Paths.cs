using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    protected float x { get; set; }
    protected float y { get; set; }
    protected float z { get; set; }

    public Paths() {
        this.x = 0f;
        this.y = 0f; 
        this.z = 0f;
    }

    public void spawnPath(GameObject randomPath){
        this.x = randomPath.transform.position.x; // needs to be endpoint of the new path
        Instantiate(randomPath, new Vector3(this.x, this.y, this.z), Quaternion.identity);
    }
}
