﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyShot : CShot {
    
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateShot", shotStartTime, shotDelayTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
