using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaAnim : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject control;
    Vector3 posIn;
    float pt=0;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        posIn=control.transform.position;

    }

    // Update is called once per frame
    void Update()
    {   
        if(control.transform.position.z>posIn.z&&control.transform.position.z<posIn.z+0.5)
        {
            pt=control.transform.position.z-posIn.z;
        }
       
        animator.SetFloat("t",pt);
    }
}
