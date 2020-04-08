using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonDetection : MonoBehaviour
{
    public GameObject Objects; 

   private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name); 
        /* foreach (Transform child in other.transform){
            Debug.Log(child.name); 
        }*/
    }
}
