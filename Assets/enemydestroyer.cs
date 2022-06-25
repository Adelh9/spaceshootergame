using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydestroyer : MonoBehaviour
{
    
   
void OnTriggerEnter2D(Collider2D col)
{
    
   /* if(Collision.gameObject.tag.Equals("Enemy"))
    {
       Destroy(collision.gameObject);
    }*/

   Destroy(gameObject);
   Destroy(col.gameObject);
}
/*void OnTriggerEnter(Collider other)
{

    if (other.gameObject.tag.Equals("Enemy"))
    {
        Destroy(other.gameObject);
    }
}*/
    // Update is called once per frame
   
}
