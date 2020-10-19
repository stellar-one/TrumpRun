using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
    Vector3 spawnPosition { get; set; }
    float currentOffset { get; set; }

    public Paths(){
        this.spawnPosition = new Vector3(0f, 0f, 0f);
        this.currentOffset = 162f;
    }

    public void spawnPath(GameObject randomPath){
        if(randomPath.name == "Straight Path")
        {
            float localOffset = currentOffset;
            Instantiate(randomPath, new Vector3(randomPath.transform.position.x + localOffset, spawnPosition.y, spawnPosition.z), Quaternion.identity);
            currentOffset += 162f;
        }
        else if(randomPath.name == "Left Path"){
            float localOffset = currentOffset;
            Instantiate(randomPath, new Vector3(randomPath.transform.position.x + localOffset, spawnPosition.y, spawnPosition.z), Quaternion.Euler(0f, -90f, 0f));
            currentOffset += 162f;
        }
        else if(randomPath.name == "Right Path"){
            float localOffset = currentOffset;
            Instantiate(randomPath, new Vector3(randomPath.transform.position.x + localOffset, spawnPosition.y, spawnPosition.z), Quaternion.Euler(0f, 90f, 0f));
            currentOffset += 162f;
            // this.transform.Rotate(new Vector3(0f, leftRight[Random.Range(0, leftRight.Length)], 0f));
        }
        else{
            Debug.Log("Error: no path found.");
        }
    }
}