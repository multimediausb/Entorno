using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ext : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject manoI;
	public ParticleSystem ps;
	public bool activo=false;
	 public Rigidbody rb;
	//public AudioSource audioData;
	//public AudioSource audioData2;
	public ParticleSystem fuego;
	public ParticleSystem humo;
	public Light lightComp;
	bool son=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
        if(activo&&GlobalInput.in2)
		{	
			ps.Play();
			//audioData2.Stop();
			if (!son)
			{
				//audioData.Play();
				son=true;
			}
			fuego.Stop();
			lightComp.enabled = false;	
			humo.Stop();
			Debug.Log("ss");
		}
	
		
    }
	private void OnTriggerStay(Collider other)
    {
			 if(other.tag == "Player")
		{ 
				if(GlobalInput.Grp2)
					{	
						transform.parent = manoI.transform;
						activo=true;
						//rb.isKinematic = true;
					}else	{	
						transform.parent = null;
						activo=false;
						//rb.isKinematic = false;
					}	
	
		}
		   
    }                                                                                                                             
	private void OnTriggerEnter(Collider other)
    {
     
    }
}
