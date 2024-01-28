using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opener : MonoBehaviour
{
    public Image open1;
    public Image open2;
    // Start is called before the first frame update
    void Start()
    {
        open1.enabled = true;
        open2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("space")){  
                if(open1.enabled){
                    open1.enabled = false;
                    open2.enabled = true;
                }else if(open2.enabled){
                        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
                    }
         }    
    }
}
