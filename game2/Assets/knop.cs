using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knop : MonoBehaviour
{   
    public Transform startpunt;
    public Transform eindpunt;

    public GameObject statue;

    private bool check = false;
    private bool moveCheck = false;
    
    public float moveSpeed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(check == true && moveCheck == false){
        Destroy(statue.transform.parent.GetComponent<PickUp>());
        statue.transform.parent.transform.parent = null;
        statue.transform.position = startpunt.position;
        moveCheck = true;
		}

        if(moveCheck == true){
        statue.transform.rotation = this.transform.rotation;
        statue.transform.position = Vector3.Lerp(statue.transform.position, eindpunt.position, moveSpeed);
        }
    }

    void OnTriggerEnter(Collider other){
     if(other.gameObject.tag == "Statue" && check == false){
     statue = other.gameObject;
     Destroy(statue.GetComponent<Rigidbody>());
     Destroy(statue.transform.parent.GetComponent<Rigidbody>());
     Destroy(statue.transform.GetChild(0).GetComponent<Rigidbody>());
     Destroy(statue.GetComponent<MeshCollider>());
     Destroy(statue.transform.GetChild(0).GetComponent<MeshCollider>());
     // >:)
     //statue.GetComponent<Rigidbody>().isKinematic = true;
     check = true;
	 }

	}
}
