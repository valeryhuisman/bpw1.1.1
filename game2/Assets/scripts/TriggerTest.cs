using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerTest : MonoBehaviour
{
   TriggerCounter triggercounter;
   bool iets =  false;
   bool triggerbool = false;
   Renderer render;

    void Start(){
    
    render = GetComponent <Renderer>();
    triggercounter = GameObject.Find("TriggerCounter").GetComponent<TriggerCounter>();
	}

    void  FixedUpdate (){
	
      if(iets==true){
     render.material.color = Color.blue;
     iets = false;
	 }

      else {
     render.material.color = Color.white;
	 }

	}

    void OnTriggerStay (Collider other){
      
     if (other.gameObject.tag == "Statue"){
     iets=true;
     if (triggerbool == false){
      triggercounter.counter+=1;
      triggerbool = true;
	 }
	 }

     
   
	}
}
