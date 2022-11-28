using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcube : MonoBehaviour
{
    public float moveforce=1;
    public static movingcube currentcube { get; private set; }
    public static movingcube lastcube { get; private set; }

    private void OnEnable()
    {
        if (lastcube == null)
        {
            lastcube = GameObject.Find("startcube").GetComponent<movingcube>();
        }
        currentcube=this;
    }

    
    void Update()
    {
        transform.position+=transform.forward*Time.deltaTime*moveforce;
    }

    internal void stop()
    {
       moveforce=0;
        float hangover = transform.position.z - lastcube.transform.position.z;
    }
}
