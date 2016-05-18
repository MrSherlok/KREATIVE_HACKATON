using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(2, 1);
    float t;
    float s;
    float d;
    public float speedByTime;

    void Start()
    {
        t = Random.Range(0, 5);
        s = Random.Range(2, 10);
        if (BirdInstScript._m == 0) {
            d = -1;
            gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f);
        } else
        {
            d = -1;
            gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f);

        }
    }

    void FixedUpdate()
    {
		Vector3 movement = new Vector3((speed.x+ s) * d, speed.y*d, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);


    }

    


}
