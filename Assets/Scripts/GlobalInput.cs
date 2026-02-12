using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class GlobalInput : MonoBehaviour
{	

	public SteamVR_Input_Sources handType1;
    public SteamVR_Action_Boolean BooleanAction1;
	public SteamVR_Action_Boolean BooleanAction1Grip;
	public SteamVR_Action_Vector2 TrackpadAction1;
	
	public SteamVR_Input_Sources handType2;
    public SteamVR_Action_Boolean BooleanAction2;	
    public SteamVR_Action_Boolean BooleanAction2Grip;
	
	
	
	private Vector2 trackpad1;
	private Vector2 trackpad2;
	
	
	public static bool in1=false;
	public static bool in2=false;
	public static bool Grp1=false;
	public static bool Grp2=false;
    void Start()
    {
		
		BooleanAction1.AddOnStateDownListener(TriggerDown1, handType1);
		BooleanAction1.AddOnStateUpListener(TriggerUp1, handType1);	
		BooleanAction1Grip.AddOnStateDownListener(GripDown1, handType1);
		BooleanAction1Grip.AddOnStateUpListener(GripUp1, handType1);


		BooleanAction2.AddOnStateDownListener(TriggerDown2, handType2);
		BooleanAction2.AddOnStateUpListener(TriggerUp2, handType2);			
        BooleanAction2Grip.AddOnStateDownListener(GripDown2, handType2);
		BooleanAction2Grip.AddOnStateUpListener(GripUp2, handType2);			
        
    }
	public void TriggerUp1(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
		Debug.Log("C1au");
		in1=false;
	}
	public void TriggerDown1(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
		Debug.Log("C1ad");	
		in1=true;
	}
	public void TriggerUp2(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
			Debug.Log("C2u");
			in2=false;
			 
	}
	public void TriggerDown2(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{

		Debug.Log("C2d");
		in2=true;
	}
	
	
		public void GripUp1(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
		Debug.Log("C1u");
		Grp1=false;
	}
	public void GripDown1(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
		Debug.Log("C1d");	
		Grp1=true;
	}
	public void GripUp2(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{
			Debug.Log("C2u");
			Grp2=false;
			 
	}
	public void GripDown2(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
	{

		Debug.Log("C2d");
		Grp2=true;
	}
    void Update()
    {
        trackpad1 = TrackpadAction1.GetAxis(handType1);
		 //Debug.Log(trackpad1.x); 
    }
}
