using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
  Transform playerPosition;
  GameObject[] obstacles;
  GameObject endPoint;

  void Awake(){
    playerPosition = GameObject.FindWithTag("Player").transform.GetChild(1);
    obstacles = GameObject.FindGameObjectsWithTag("Enemy");
    endPoint = GameObject.FindWithTag("Finish");
  }
  
  void Update(){
    if(playerPosition.transform.position.x == -endPoint.transform.position.x - 300){
      generatePath();
    }
  }

  private void generatePath(){
    GameObject randomObj = obstacles[Random.Range(0,obstacles.Length)];
    generateLevelObstacle(new Vector3(0, 0, 520), randomObj); 
  }
  
  private void generateLevelObstacle(Vector3 spawnPosition, GameObject obstacle){
    Instantiate(obstacle, spawnPosition, Quaternion.identity);
  }

}
