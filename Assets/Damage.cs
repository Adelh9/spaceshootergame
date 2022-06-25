using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
  
 [SerializeField] public float dmg;
 [SerializeField]public string hit; 
 int score;

void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == hit){

        other.gameObject.GetComponent<Healthmanager>().TakeDamage(dmg);
        if (hit == "Enemy")
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score")+50 );

        }
    }
}
void Start(){


}



}
