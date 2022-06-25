using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public GameObject Bullet;
    public Slider Healthslider;
    // Start is called before the first frame update
    public float speed = 5000f;
      Rigidbody2D player;
      //private Camera mainCamera;
      public float min = -4f;
      public float max = 4f;
      public float padding=1f;
      public AudioSource shooting;
    void Start()
    {
        //mainCamera=Camera.main;
       Time.timeScale=0;
     PlayerPrefs.SetInt("score",0);
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
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(Bullet,transform.position,Quaternion.identity);
        }
            if (Input.GetButtonDown("Fire1"))
        {
            Vector3 playerPosition = transform.position;

            Instantiate(Bullet, playerPosition, Quaternion.identity);

            shooting.Play();
        }
        
        /*Cameracam=gameObject.GetComponent<Camera>();

        float distance=transform.position.z-Camera.main.main.transform.position.z;
        Vector3 leftmost=Cameracam(new Vector3(0,0,distance));

        Vector3 leftmost=Cameracam(new Vector3(1,0,distance));
        min=leftmost.x;
        max=rightmost.y;*/
     

        if(Input.GetKey(KeyCode.A))
        {
           //transform.position += new Vector3(-speed*Time.deltaTime,0,0);
           //player.velocity=-transform.right*speed;
           transform.position+=transform.right*-speed*Time.deltaTime;
           

        }
        else if(Input.GetKey(KeyCode.D))
        {
           // transform.position += new Vector3(speed*Time.deltaTime,0,0);
            //player.velocity=transform.right*speed;
            transform.position+=transform.right*speed*Time.deltaTime;
             

        }


        Healthslider.value=GetComponent<Healthmanager>().health;

    }


   public void unfreeze(){
        Time.timeScale= 1;
    }

    public void replay(){

        SceneManager.LoadScene("SampleScene");
    }
}
