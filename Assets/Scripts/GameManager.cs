using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
  GameObject player;
  GameObject[] obstacles;
  // GameObject endPoint;

  void Awake(){
    player = GameObject.FindWithTag("Player").transform.GetChild(0).gameObject;
    obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    // endPoint = GameObject.FindWithTag("Finish");
  }

  void Start(){
    StartCoroutine(SpawnObstaclesCoroutine(obstacles[0].transform));
    StartCoroutine(SpawnObstaclesCoroutine(obstacles[1].transform));
    StartCoroutine(SpawnObstaclesCoroutine(obstacles[2].transform));
  }

  IEnumerator SpawnObstaclesCoroutine(Transform obstacle){
    WaitForSeconds waitTime = new WaitForSeconds(2);
    while (true) {
      Instantiate(obstacle, new Vector3(Random.Range(player.transform.localPosition.z, player.transform.localPosition.z + 50f), 2f, Random.Range(-10f, 10f)), Quaternion.identity);
      yield return waitTime;
    }
  }
}