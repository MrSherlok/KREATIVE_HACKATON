using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(2, 1);
    public float t;
    public float s;
    public float d;
    public float speedByTime;

    void Start()
    {
        t = Random.Range(0, 5);
        s = Random.Range(4, 10);
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
        Vector3 movement = new Vector3((speed.x+ s) * d, 0.3f*d, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);


    }

    


}
