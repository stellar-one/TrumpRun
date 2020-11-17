/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelGenerator : MonoBehaviour
{
  [SerializeField] private Transform Object_Generator;
 
  public Transform lastObj;  

  void Start(){
      Transform[] childs = Object_Generator.GetComponentsInChildren<Transform>();
      Transform randomObject = childs[0];
      float y = 0;
      float z = 0;
      float x = 520;
      lastObj = randomObject; 
      generateLevelObstacle(new Vector3(x,y,z), randomObject);
      
  }

  private void waitFiveSec(){
  }
   void Update(){
    Transform[] childs = Object_Generator.GetComponentsInChildren<Transform>();
    
 
      Transform randomObject = childs[0];                                                 //Random.Range(0,childs.Length)
      if(lastObj.transform.position.x < 450){                                            // try to use yield or a timer make lastObj a reference
        float y = 0;
        float z = 0;
        float x = 520;
        lastObj = randomObject; 
        generateLevelObstacle(new Vector3(x,y,z), randomObject); 
        Debug.Log(lastObj.position.x);
      } 
  
  }

  

  private void generateLevelObstacle(Vector3 spawnPosition, Transform randomObject){
     Instantiate(randomObject, spawnPosition, Quaternion.identity);    //.getChidCount
  }

}*/
