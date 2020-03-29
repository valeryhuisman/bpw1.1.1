using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCounter : MonoBehaviour

{
  public GameObject sign;
  public int counter;
  public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        trigger.SetActive (false);
         
    }

    // Update is called once per frame
    void Update()
    {
        if ( counter >= 5) {
      
      trigger.SetActive (true);
      sign.SetActive(true);
  
		}
    }
}
