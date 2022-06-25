using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthmanager : MonoBehaviour
{

    
          public AudioSource destroy;
public int score;
public GameObject gameover;
    [SerializeField] public float health;
    // Start is called before the first frame update
    public void  TakeDamage(float amount){
    health -= amount; 
   
   
   
    if(health <= 0)
    {
        if (this.gameObject.tag=="Player")
        {
            
                health = 0;
             Destroy(this.gameObject);
            gameover.SetActive(true);


        }
            if (this.gameObject.tag=="Enemy")
        {
            
                health = 0;

                destroy.Play();
             StartCoroutine(desactivate());
          

        }
        
        

    
    }
}

IEnumerator desactivate()
{

      this.gameObject.GetComponent<SpriteRenderer>().enabled=false;
      this.gameObject.GetComponent<BoxCollider2D>().enabled=false;
        yield return new WaitForSeconds(10f);
this.gameObject.GetComponent<SpriteRenderer>().enabled=true;
      this.gameObject.GetComponent<BoxCollider2D>().enabled=true;


}


    void Start()
    {
       score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
