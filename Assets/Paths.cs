using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paths : MonoBehaviour
{
<<<<<<< HEAD:Assets/Scripts/Paths.cs
    Vector3 spawnPosition { get; set; }
    float currentOffset { get; set; }
=======
    // Vector3 position {get; set; }
    protected float x { get; set; }
    protected float y { get; set; }
    protected float z { get; set; }
>>>>>>> parent of b745d6f... saving progress, see description...:Assets/Paths.cs

    public Paths(){
        this.spawnPosition = new Vector3(0f, 0f, 0f);
        this.currentOffset = 162f;
    }

<<<<<<< HEAD:Assets/Scripts/Paths.cs
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
=======
    public void spawnPath(GameObject randomPath, GameObject endPoint){
        this.x = endPoint.transform.localPosition.x;
        Instantiate(randomPath, new Vector3(this.x, this.y, this.z), Quaternion.identity);
>>>>>>> parent of b745d6f... saving progress, see description...:Assets/Paths.cs
    }
}