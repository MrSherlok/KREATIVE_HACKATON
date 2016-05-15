using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour
{

    public float destTime;
    float time;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, destTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            Musordetector.litterMiss++;
        }
    }
}

