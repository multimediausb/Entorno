using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPos : MonoBehaviour
{
   public Vector3 pos;
    void Start()
    {
        transform.position=transform.position+new Vector3(pos.x,pos.y,pos.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
