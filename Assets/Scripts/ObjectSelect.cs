
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour
{
	public Rigidbody rb;
	public bool activo=false;
	public GameObject manoI;
	public GameObject resetPos;
	
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerStay(Collider other)
    {
		 if(other.tag == "Player")
		{ 
			Debug.Log(other.tag);
			if(GlobalInput.Grp2)
			{	
				transform.parent = manoI.transform;
				activo=true;
				rb.isKinematic = true;
			} 
			if(!GlobalInput.Grp2)	{	
				transform.position=new Vector3(resetPos.transform.position.x,resetPos.transform.position.y,resetPos.transform.position.z);
				transform.parent = resetPos.transform;
				
				activo=false;
				rb.isKinematic = false;
			}	
		
		}
		   
    }
	
}
