using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BritMovement : MonoBehaviour
{
    public Image dia1;
    public Image dia2;
    public Image dia3;
    public Image dia4;
    public Image dia5;
    public Image dia6;
    public Image dia7;
    public Image dia8;

    public BoxCollider2D boxCollider;
 
    public GameObject JokeBtn;

    // Start is called before the first frame update
    void Start()
    {
        dia1.enabled = false;
        dia2.enabled = false;
        dia3.enabled = false;
        dia4.enabled = false;
        dia5.enabled = false;
        dia6.enabled = false;
        dia6.enabled = false;
        dia7.enabled = false;
        dia8.enabled = false;
        JokeBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            if(dia1.enabled){
                dia1.enabled = false;
                dia2.enabled = true;
            }else{
                if(dia2.enabled){
                    dia2.enabled = false;
                    dia3.enabled = true;
                }
                else if(dia3.enabled) {
                    dia3.enabled = false;
                    dia4.enabled = true;
                }
                else if(dia4.enabled) {
                    dia4.enabled = false;
                    dia5.enabled = true;
                }
                else if(dia5.enabled) { 
                    dia5.enabled = false;
                    dia6.enabled = true;
                }
                else if(dia6.enabled) {
                    dia6.enabled = false;
                    dia7.enabled = true;
                }
                 else if(dia7.enabled) {
                    dia7.enabled = false;
                    dia8.enabled = true;
                }
                else if(dia8.enabled) {
                    dia8.enabled = false;
                    JokeBtn.SetActive(true);
                }
            }
            
        }
    }

    void dialogue(){
        
    }

    private void OnCollisionEnter2D() {

        dia1.enabled = true;
    }
}
