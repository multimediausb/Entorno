using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorPalanca : MonoBehaviour
{
    public GameObject door;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Palanca")
		{ 
        Renderer rend=door.GetComponent<Renderer> ();
         rend.material.color= Color.red;
       }
    }
    void OnTriggerExit(Collider other)
    {
         if(other.tag == "Palanca")
		{ 
            Renderer rend=door.GetComponent<Renderer> ();
        rend.material.color= Color.green;
        }
    }
}
