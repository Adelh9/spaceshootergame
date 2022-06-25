using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{

    public Text Scoretxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scoretxt.text= PlayerPrefs.GetInt("score").ToString();
    }

      public void replay(){

        SceneManager.LoadScene("SampleScene");
    }
}
