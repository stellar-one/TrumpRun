using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
  GameObject player;
  GameObject[] obstacles;
  int objectSpawnTime;
  // GameObject endPoint;

  void Awake(){
    player = GameObject.FindWithTag("MainCamera"); // current solution because player game object falls through the ground...
    obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    objectSpawnTime = 5;
    // endPoint = GameObject.FindWithTag("Finish");
  }

  void Start(){
    StartCoroutine(SpawnObstaclesCoroutine(obstacles));
  }

  IEnumerator SpawnObstaclesCoroutine(GameObject[] objs){
    WaitForSeconds waitTime = new WaitForSeconds(objectSpawnTime);
    while (true) {
      GameObject randomObj = objs[Random.Range(0, objs.Length)];
      randomObj.GetComponent<Obstacle>().spawnObject(randomObj, player);
      yield return waitTime;
    }
  }
}