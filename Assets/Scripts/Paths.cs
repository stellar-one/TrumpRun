using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    protected Vector3 spawnPosition { get; set; }
    private float currentOffset { get; set; }

    public Paths(){
        this.spawnPosition = new Vector3(0f, 0f, 0f);
        this.currentOffset = 162f;
    }

    public void spawnPath(GameObject randomPath){
        Vector3 localOffset = new Vector3(currentOffset, 0, 0); //offset for first road block
        Instantiate(randomPath, new Vector3(randomPath.transform.position.x + localOffset.x, spawnPosition.y, spawnPosition.z), Quaternion.identity);
        currentOffset += 162f;
    }
}