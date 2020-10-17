using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
  GameObject player;
  GameObject[] obstacles;
  // GameObject endPoint;

  void Awake(){
    player = GameObject.FindWithTag("MainCamera");
    obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    // endPoint = GameObject.FindWithTag("Finish");
  }

  void Start(){
    StartCoroutine(SpawnObstaclesCoroutine(obstacles));
    // StartCoroutine(SpawnObstaclesCoroutine(obstacles[1].transform));
    // StartCoroutine(SpawnObstaclesCoroutine(obstacles[2].transform));
  }

  IEnumerator SpawnObstaclesCoroutine(GameObject[] objs){
    WaitForSeconds waitTime = new WaitForSeconds(2);
    while (true) {
      GameObject randomObj = objs[Random.Range(0, objs.Length)];
      if(randomObj.name == "Floating"){
        Instantiate(randomObj.transform, new Vector3(Random.Range(player.transform.localPosition.x + 100f, player.transform.localPosition.x + 150f), 5f, 0f), Quaternion.identity);
      }
      else if(randomObj.name == "Rectangle"){
        Instantiate(randomObj.transform, new Vector3(Random.Range(player.transform.localPosition.x + 100f, player.transform.localPosition.x + 150f), 2f, Random.Range(-4.5f, 5f)), Quaternion.identity);
      }
      else if(randomObj.name == "Cube"){
        Instantiate(randomObj.transform, new Vector3(Random.Range(player.transform.localPosition.x + 100f, player.transform.localPosition.x + 150f), 2f, Random.Range(-6.5f, 7)), Quaternion.identity);
      }
      yield return waitTime;
    }
  }
}