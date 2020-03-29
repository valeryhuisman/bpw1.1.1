using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{
  
    public GameObject Cam1;
    public GameObject Cam2;

    void Start()
    {
    StartCoroutine(TheSequence());
        
    }

    IEnumerator TheSequence() {
    
    yield return new WaitForSeconds (4);
    Cam1.SetActive (true);
    Cam2.SetActive (false); 
       yield return new WaitForSeconds (4);
    Cam2.SetActive (true);
    Cam1.SetActive (false); 
	}
  
}
