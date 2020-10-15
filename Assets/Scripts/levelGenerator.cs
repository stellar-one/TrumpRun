using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelGenerator : MonoBehaviour
{
  [SerializeField] private Transform Object_Generator;

  private void Awake(){
    int z = Random.Range(-5,4);
    int x = Random.Range(20,60);
    while ( x < 500) {
      generateLevelObstacle(new Vector3(x,2,z));
      x += Random.Range(5,45);
      z = Random.Range(-5,4);  
    }
  }

  private void generateLevelObstacle(Vector3 spawnPosition){
     Instantiate(Object_Generator, spawnPosition, Quaternion .identity);
  }

}
