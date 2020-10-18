using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
  GameObject player;
  GameObject[] obstacles;
  GameObject[] paths;
  int objectSpawnTime;
  GameObject endPoint;

  void Awake(){
    player = GameObject.FindWithTag("MainCamera"); // current solution because player game object falls through the ground...
    obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    paths = GameObject.FindGameObjectsWithTag("Path");
    objectSpawnTime = 5;
    // endPoint = GameObject.FindWithTag("Finish");
  }

  void Start(){
    StartCoroutine(SpawnObstaclesCoroutine(obstacles));
    StartCoroutine(generatePath(paths));
  }

  IEnumerator SpawnObstaclesCoroutine(GameObject[] objs){
    WaitForSeconds waitTime = new WaitForSeconds(objectSpawnTime);
    while (true) {
      GameObject randomObj = objs[Random.Range(0, objs.Length)];
      randomObj.GetComponent<Obstacle>().spawnObject(randomObj, player);
      yield return waitTime;
    }
  }

  IEnumerator generatePath(GameObject[] paths){
    WaitForSeconds waitTime = new WaitForSeconds(15);
    while (true) {
      GameObject randomPath = paths[Random.Range(0, paths.Length)];
      randomPath.GetComponent<Paths>().spawnPath(randomPath, randomPath);
      yield return waitTime;
    }
  }
}