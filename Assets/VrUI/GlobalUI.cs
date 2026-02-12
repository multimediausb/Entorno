           using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class GlobalUI : MonoBehaviour
{
    public GameObject Inicio;
	public GameObject Ayuda;
	public GameObject Opciones;
	public GameObject Info;
	public GameObject Salir;
	////////////////////////////////
	public GameObject Ac1;
	public GameObject Ac2;
	public GameObject Ac3;
	public GameObject Ac4;
	public GameObject Ac5;
	public GameObject Ac6;
	public GameObject Ac7;
		public GameObject Jugador;
	public GameObject Fxs;
    void Start()
    {
        
    }
	
	public void visibles()
	{
		Inicio.SetActive(false);
		Ayuda.SetActive(false);
		Opciones.SetActive(false);
		Info.SetActive(false);
		Salir.SetActive(false);
		Ac1.SetActive(false);
		Ac2.SetActive(false);
		Ac3.SetActive(false);
		Ac4.SetActive(false);
		Ac5.SetActive(false);
		Ac6.SetActive(false);
		Ac7.SetActive(false);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
	public void btIncio()
	{	
		visibles();
		Inicio.SetActive(true);
	}
	public void btAyuda()
	{
		visibles();
		Ayuda.SetActive(true);
	}
	public void btOpciones()
	{
		visibles();
		Opciones.SetActive(true);
	}
	public void btInfo()
	{
		visibles();
		Info.SetActive(true);
	}
	public void btSalir()
	{
		visibles();
		Salir.SetActive(true);
	}
	public void btAc1()
	{
		visibles();
		Ac1.SetActive(true);
	}
	public void btAc2()
	{
		
		visibles();
		Ac2.SetActive(true);
	}
	public void btAc3()
	{
		
		visibles();
		Ac3.SetActive(true);
	}
		public void btAc4()
	{
		
		visibles();
		Ac4.SetActive(true);
	}
		public void btAc5()
	{
		
		visibles();
		Ac5.SetActive(true);
	}
	public void btAc6()
	{
		
		visibles();
		Ac6.SetActive(true);
	}
		public void btAc7()
	{
		
		visibles();
		Ac7.SetActive(true);
	}

	public void sc1()
	{
		Jugador.transform.position=new Vector3(-2.346f,-1.082f,3.064f);
		   //SceneManager.LoadScene("sn1");
	}
	public void sc2()
	{
		Jugador.transform.position=new Vector3(-3.277959f,-1.149f,3.754759f);
		Fxs.SetActive(true);  
		  // SceneManager.LoadScene("sn2");
	}
	public void sc3()
	{
		Jugador.transform.position=new Vector3(-13.59f,-3.956f,3.255f);
		  // SceneManager.LoadScene("sn3");
	}
	public void sc4()
	{
		
		  // SceneManager.LoadScene("sn4");
	}
		public void salir()
	{
		
		   Application.Quit();
	}

}
