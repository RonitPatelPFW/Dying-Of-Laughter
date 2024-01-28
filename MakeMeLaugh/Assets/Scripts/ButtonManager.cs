using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public GameObject options; 
    public Image preJoke;
    public Image actualJoke;
    public Image goodEnd;
    public Image badEnd;
    int randomNumber;
    // Start is called before the first frame update

    void Start() {
        preJoke.enabled = false;
        actualJoke.enabled = false;
        goodEnd.enabled = false;
        badEnd.enabled = false;
        options.SetActive(false);
    }
    public void tellJoke()
    {
        preJoke.enabled = true;
        randomNumber = Random.Range(0, 1);
        
    }
    void Update() {
        if(randomNumber == 1){
            if(Input.GetKeyDown("space")){  
                if(preJoke.enabled){
                    preJoke.enabled = false;
                    actualJoke.enabled = true;
                }else if(actualJoke.enabled){
                        actualJoke.enabled = false;
                        goodEnd.enabled = true;
                    }
                    else if(goodEnd.enabled) {
                        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                        // goodEnd.enabled = false;

                }
            }
       }
        else {
            if(Input.GetKeyDown("space")){
            if(preJoke.enabled){
                preJoke.enabled = false;
                actualJoke.enabled = true;
            }else if(actualJoke.enabled){
                    actualJoke.enabled = false;
                    badEnd.enabled = true;
                }
                else if(badEnd.enabled) {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                    // badEnd.enabled = false;
                }
            }
        }
        
    }
    public void dont(){
        options.SetActive(false);
    }
}
