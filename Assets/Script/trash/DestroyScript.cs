using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour
{
    public float destTime;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, destTime);
    }
}

