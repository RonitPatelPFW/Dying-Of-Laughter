using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public Image diaOne;
    public Image diaTwo;
    public Image diaThree;

    // Start is called before the first frame update
    void Start()
    {
        diaOne.enabled = false;
        diaTwo.enabled = false;
        diaThree.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            if(diaOne.enabled){
                diaOne.enabled = false;
                diaTwo.enabled = true;
            }else{
                if(diaTwo.enabled){
                    diaTwo.enabled = false;
                    diaThree.enabled = true;
                }else{
                    diaOne.enabled = true;
                }
                
            }
            
        }
    }

    void dialogue(){
        
    }
}