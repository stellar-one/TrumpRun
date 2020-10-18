using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Vector3 position {get; set; }
    protected float x { get; set; }
    protected float y { get; set; }
    protected float z { get; set; }

    public Obstacle() {
        this.x = 0f;
        this.y = 0f; 
        this.z = 0f;
    }

    public void spawnObject(GameObject radomObj, GameObject player){
        this.x = Random.Range(player.transform.localPosition.x + 50f, player.transform.localPosition.x + 100f);
        Instantiate(radomObj, new Vector3(this.x, this.y, this.z), Quaternion.identity);
    }
}
