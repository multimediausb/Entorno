using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VrButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
		Button btn = GetComponent<Button>();
		btn.onClick.Invoke();
    }
}
