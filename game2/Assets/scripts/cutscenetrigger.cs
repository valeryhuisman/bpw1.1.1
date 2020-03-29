using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cutscenetrigger : MonoBehaviour
{
   public GameObject thePlayer;
   public GameObject cutsceneCam;
   public GameObject cutsceneCam1;
    public GameObject rain;

   void OnTriggerEnter ( Collider other)
  {
   this.gameObject.GetComponent<BoxCollider>().enabled = false;
   cutsceneCam.SetActive(true);
   cutsceneCam1.SetActive(false);
   thePlayer.SetActive(false);
   rain.SetActive(true);
   StartCoroutine(FinishCut());
   }

   IEnumerator FinishCut()
   {
   yield return new WaitForSeconds (5);
   cutsceneCam1.SetActive(true);
   cutsceneCam.SetActive(false);
   
   yield return new WaitForSeconds (5);
   thePlayer.SetActive(true);
   cutsceneCam.SetActive(false);
   cutsceneCam1.SetActive(false);

   Cursor.visible = true;
   Cursor.lockState = CursorLockMode.None;
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

   }



 
}
