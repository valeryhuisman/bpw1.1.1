using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility : MonoBehaviour
{
    void OnLevelWasLoaded(int level)
    {
            Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //Debug.Log("This is working, bot not the cursor");
        
    }
}