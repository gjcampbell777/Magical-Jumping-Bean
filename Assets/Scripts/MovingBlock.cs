﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    
    public bool xaxis;
    public bool zaxis;
    public float speed;
    public GameObject block;
    public Material rotten;

    bool moveXpos;
    bool moveZpos;

 	Vector3 startPos;
 	MeshRenderer mr;

    void Start()
    {

    	startPos = block.transform.position;

    	if(Random.Range(0,2) == 0)
    	{
    		xaxis = true;
    	} else {
    		xaxis = false;
    	}

    	if(Random.Range(0,2) == 0)
    	{
    		zaxis = true;
    	} else {
    		zaxis = false;
    	}

    	if(Random.Range(0,2) == 0)
    	{
    		moveXpos = true;
    	} else {
    		moveXpos = false;
    	}

    	if(Random.Range(0,2) == 0)
    	{
    		moveZpos = true;
    	} else {
    		moveZpos = false;
    	}

    	if(!xaxis && !zaxis)
    	{
    		mr = this.GetComponent<MeshRenderer>();
        	mr.material = rotten;
    	}

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    	if(xaxis)
    	{
    		if(block.transform.position.x > startPos.x+15)
    		{
    			moveXpos = false;
    		}

    		if(block.transform.position.x < startPos.x-15)
    		{
    			moveXpos = true;
    		}

    		if(moveXpos) transform.position += Vector3.right * Time.deltaTime * speed;
    		if(!moveXpos) transform.position += Vector3.left * Time.deltaTime * speed;
    	}

    	if(zaxis)
    	{

    		if(block.transform.position.z > startPos.z+15)
    		{
    			moveZpos = false;
    		}

    		if(block.transform.position.z < startPos.z-15)
    		{
    			moveZpos = true;
    		}

    		if(moveZpos) transform.position += Vector3.forward * Time.deltaTime * speed;
    		if(!moveZpos) transform.position += Vector3.back * Time.deltaTime * speed;

    	}

    }
}
