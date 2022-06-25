using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
    [SerializeField]
    private float speed = 50;
    public GameObject Bullet;




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

   void shoot()
    {
       
            
              if (this.gameObject.GetComponent<SpriteRenderer>().enabled == true)
{
             Vector3 playerPosition = transform.position;

            
            Instantiate(Bullet, playerPosition, Quaternion.identity);
}

    }
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("shoot", 1.0f, 1.0f);
        
    }

    // Update is called once per frame
   
}
