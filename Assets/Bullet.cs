using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 250;
   
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,3.0f);
    }
  
 
 /* public class MyBullet{
     
               private void OnCollisionEnter(Collision other) {
                      if (other.gameObject.CompareTag("Enemy")){
                                 Destroy(other.gameObject); // this destroys the enemy
                                 Destroy(gameObject); // this destroys the bullet
                      }
               }
 }*/

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.tag=="Bullet")
        {
               
               Vector3 direction = Vector3.up;

        
         float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;

      
        transform.Translate(
          translation

                                );
        }

     if(this.gameObject.tag=="EnemyBullet")
     {
             Vector3 direction = Vector3.down;

        
        float timeSinceLastFrame = Time.deltaTime;

        Vector3 translation = direction * speed * timeSinceLastFrame;

      
        transform.Translate(
          translation
        );
     } 
    }
void OnTriggerEnter2D(Collider2D col){
      if (col.gameObject.tag == "Player" && this.gameObject.tag == "EnemyBullet" )
    Destroy(this.gameObject);   
    
     if (col.gameObject.tag == "Enemy" && this.gameObject.tag == "Bullet" )
     
    Destroy(this.gameObject);   
    }

}
