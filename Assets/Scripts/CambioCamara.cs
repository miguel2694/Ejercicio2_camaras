using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Camera normal;
    public Camera mosca; 
   

   public void ShowNormalView(){
        normal.enabled = false;
        mosca.enabled = true;
   }
    

    // Update is called once per frame
    public void ShowMoscaView()
    {
        normal.enabled = true;
        mosca.enabled = false;
    }


    void Start(){
        ShowNormalView();
    }


    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && normal.enabled == false){
            ShowMoscaView();
           
        }else if(Input.GetKeyDown(KeyCode.Space) && normal.enabled == true){
            ShowNormalView();
        }
    }
}




