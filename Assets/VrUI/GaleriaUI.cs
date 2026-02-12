using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaleriaUI : MonoBehaviour
{
    public GameObject[] paneles;
	public int actual=0;
    void Start()
    {
		 for (int i = 1; i < paneles.Length; i++)
		 {
        paneles[i].SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void btS()
	{
		 paneles[actual].SetActive(false);
		  paneles[actual+1].SetActive(true);
		  //if(actual<paneles.Length-2)
		  { actual++;}
		 
	}
	public void btA()
	{
		paneles[actual].SetActive(false);
		  paneles[actual-1].SetActive(true);
		   //if(actual>1)
		  { actual--;}
		 
	}
}
