using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVrObj : MonoBehaviour
{
     public GameObject VrUI;
	 bool vis=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
    {
       vis=!vis;
		VrUI.SetActive(vis);
		
		
    }
}
