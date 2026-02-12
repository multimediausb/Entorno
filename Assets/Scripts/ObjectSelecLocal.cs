using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelecLocal : MonoBehaviour
{
    // Start is called before the first frame update
    //public Rigidbody rb;
	public bool activo=false;
	public GameObject manoI;
	public GameObject padre;
	
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        	if(!GlobalInput.Grp2)	{	
				
				transform.parent = padre.transform;
				
				activo=false;
				//rb.isKinematic = false;
			}
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
				//rb.isKinematic = true;
			} 
			if(!GlobalInput.Grp2)	{	
				
				transform.parent = padre.transform;
				
				activo=false;
				//rb.isKinematic = false;
			}	
		
		}
		   
    }
}
