﻿using UnityEngine;
using System.Collections;

public class BirdInstScript : MonoBehaviour {
    public static int kal = 0;
    public GameObject birdPref;
    public static int _m;
    Vector3 poss;
    float time;
    public float _t = 1;
    

	void Update () {
        
        time -= Time.deltaTime;
        if(time <= 0)
        {
            _m = Random.Range(0, 2);
            poss.y = Random.Range(35f, 50f) * 10f;
            if (_m == 0) poss.x = -60f; else poss.x = 1000f;
            Instantiate(birdPref, poss, Quaternion.identity);
            time = _t;
        }
    }
}
