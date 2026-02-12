using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelUIcabina : MonoBehaviour
{
   	public GameObject pnAudio;
   	public GameObject pnLuz;
   	public GameObject pnTemp;
   	public GameObject pnDoor;
   	public GameObject pnSmoke;
	public GameObject pnSeat;
	public GameObject pnAgua;
	public GameObject pnSistem;
	public GameObject pnGeneral;
    void Start()
    {
		
		
		
	}
	void invisibles()
    {
		pnLuz.SetActive(false);
		pnAudio.SetActive(false);
		pnTemp.SetActive(false);
		pnDoor.SetActive(false);
		pnSmoke.SetActive(false);
		pnSeat.SetActive(false);
		pnAgua.SetActive(false);
		pnSistem.SetActive(false);
		pnGeneral.SetActive(false);
	}
	public void btnLuz()
	{
		invisibles();
		pnLuz.SetActive(true);
	}
	public void btnAudio()
	{
		invisibles();
		pnAudio.SetActive(true);
	}
	public void btnTemp()
	{
		invisibles();
		pnTemp.SetActive(true);
	}
	public void btnDoor()
	{
		invisibles();
		pnDoor.SetActive(true);
	}
	public void btnAgua()
	{
		invisibles();
		pnAgua.SetActive(true);
	}
	public void btnSmoke()
	{
		invisibles();
		pnSmoke.SetActive(true);
	}
	public void btnSeat()
	{
		invisibles();
		pnSeat.SetActive(true);
	}
	public void btnSistema()
	{
		invisibles();
		pnSistem.SetActive(true);
	}
	public void btnGeneral()
	{
		invisibles();
		pnGeneral.SetActive(true);
	}
}
