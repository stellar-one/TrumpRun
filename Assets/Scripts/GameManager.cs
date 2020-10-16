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
    obstacles = GameObject.FindGameObjectsWithTag("Enemy");
    // endPoint = GameObject.FindWithTag("Finish");
  }

  void Start(){
    StartCoroutine(SpawnObstaclesCoroutine(new Vector3(0f, 1f, 1f), obstacles[0]));
    StartCoroutine(SpawnObstaclesCoroutine(new Vector3(1f, 2f, 2f), obstacles[0]));
    StartCoroutine(SpawnObstaclesCoroutine(new Vector3(2f, 3f, 3f), obstacles[0]));
    // StartCoroutine(SpawnObstaclesCoroutine(new Vector3(Random.Range(player.transform.localPosition.z, player.transform.localPosition.z + 50f), 2f, 2f), obstacles[1]));
    // StartCoroutine(SpawnObstaclesCoroutine(new Vector3(Random.Range(player.transform.localPosition.z, player.transform.localPosition.z + 50f), 3f, 3f), obstacles[2]));
  }

  IEnumerator SpawnObstaclesCoroutine (Vector3 spawnPosition, GameObject obstacle)
    {
        WaitForSeconds waitTime = new WaitForSeconds(2);
        while (true) {
            Instantiate(obstacle.transform, spawnPosition, Quaternion.identity);
            yield return waitTime;
        }
    }

}
