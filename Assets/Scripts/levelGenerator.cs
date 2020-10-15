using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
  [SerializeField] private Transform Object_Generator;


  private void Awake(){
      generateLevelObstacle(new Vector3(60,2,0));
  }

  private void generateLevelObstacle(Vector3 spawnPosition){
     Instantiate(Object_Generator, spawnPosition, Quaternion .identity);
  }

  //private void generate(){
   //   Instantiate(Obstacle_Generator, new Vector3(194,95,-64), Quaternion .identity);
  ///}
}
