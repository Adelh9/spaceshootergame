using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    //public Transform[] spawnpoints;
   // public GameObject[] enemyprefab; 

    public float speed=500f;
    public float min = -4f;
    public float max = 4f;
    public bool ismoveright=true;
    public float width=5f;
    public float height=5f;
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;
    public GameObject position5;
    GameObject enemyprefab;

    // Start is called before the first frame update
    void Start()
    {
       
        foreach(Transform child in transform)
        {
             
              GameObject enemyprefab=Instantiate(enemy,child.transform.position, Quaternion.identity)as GameObject;
               enemyprefab.transform.parent=child;
               enemyprefab.transform.eulerAngles=new Vector3(0,0,180);

        }
      /*   enemyprefab=Instantiate(enemy,position1.transform.position, Quaternion.identity)as GameObject;
         enemyprefab=Instantiate(enemy,position2.transform.position, Quaternion.identity)as GameObject;
         enemyprefab=Instantiate(enemy,position3.transform.position, Quaternion.identity)as GameObject;
         enemyprefab=Instantiate(enemy,position4.transform.position, Quaternion.identity)as GameObject;
         enemyprefab=Instantiate(enemy,position5.transform.position, Quaternion.identity)as GameObject;*/
    }

      void FixedUpdate()
    {
         if(transform.position.x >= 32.1f)
         {
            transform.position = new Vector3(32.1f,-16.1f,0);
         }
          if(transform.position.x <= -30.4f)
         {
             transform.position = new Vector3(-30.4f,-16.1f,0);
         }
    }




    void Update()
    {
     /* if (Input.GetMouseButtonDown(0))
      {
         int RandEnemy=Random.Range(0,enemyprefab.Length);
         int RandSpawnEnemy=Random.Range(0,spawnpoints.Length);
         Instantiate(enemyprefab[0],spawnpoints[RandSpawnEnemy].position,transform.rotation);
      }*/
      if(ismoveright==true&&transform.position.x>max)
      {
          transform.position += Vector3.right*speed*Time.deltaTime;
      } 
      if (transform.position.x==max)
      {
          ismoveright=false;
      }
      if (transform.position.x==min)
      {
          ismoveright=true;
      }
    else  if(ismoveright==false&&transform.position.x<min)
      {
          transform.position += Vector3.left*speed*Time.deltaTime;
      } 


    }
    void OnDrawGizmos()
    {
         Gizmos.DrawWireCube(transform.position,new Vector3(height,width));
            
    }
    
}
