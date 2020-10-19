using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    protected Vector3 spawnPosition { get; set; }

    public Paths() {
        this.spawnPosition = new Vector3(0f, 4f, 0f);
    }

    public void spawnPath(GameObject randomPath, GameObject lastPath){
        // this.x = randomPath.transform.position.x; // needs to be endpoint of the new path
        
        this.spawnPosition = new Vector3(lastPath.transform.position.x, spawnPosition.y, spawnPosition.z);
        Instantiate(randomPath, this.spawnPosition, Quaternion.identity);
    }
}
