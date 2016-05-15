using UnityEngine;
using System.Collections;

public class BirdInstScript : MonoBehaviour {

    public GameObject birdPref;
    public static int _m;
    Vector3 poss;
    float time;
    public float _t = 1;
    
    void Start ()
    {
        _m = Random.Range(0, 2);
        poss.y = Random.Range(2.2f, 4.4f);

    }

	void Update () {
        if (_m == 0) poss.x = -10f; else poss.x = 10f;
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Instantiate(birdPref, poss, Quaternion.identity);
            time = _t;
        }
    }
}
