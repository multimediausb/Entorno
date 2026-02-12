using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPos : MonoBehaviour
{
     // Start is called before the first frame update
    Animator animator;
    public GameObject control;
    public GameObject controlFinal;
    Vector3 posIn;
    float pt=0;
    public int x=0;
    public int y=0;
    public int z=0;
    public float pn=0.5f;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        posIn=control.transform.position;

    }

    // Update is called once per frame
    void Update()
    {   if(z==1)
        {
            if(control.transform.position.z>posIn.z&&control.transform.position.z<posIn.z+pn)
            {
                pt=-(posIn.z-control.transform.position.z)/pn;
            }

        }
        if(z==-1)
        {
            if(control.transform.position.z>posIn.z&&control.transform.position.z<posIn.z+pn)
            {
                pt=(posIn.z-control.transform.position.z)/pn;
            }

        }
        if(x==1)
        {
            if(control.transform.position.x>posIn.x&&control.transform.position.x<posIn.x+1)
            {
                pt=control.transform.position.x-posIn.x;
            }

        }
        if(y==1)
        {
            if(control.transform.position.y>posIn.y&&control.transform.position.y<posIn.y+pn)
            {
                pt=-(posIn.y-control.transform.position.y)/pn;
            }

        }
        animator.SetFloat("t",pt);
    }
}
