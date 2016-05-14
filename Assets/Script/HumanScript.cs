using UnityEngine;
using System.Collections;

public class HumanScript : MonoBehaviour {
    public GameObject human1;
    public Vector3 pos;
    Quaternion rot;
    void Start ()
    {
        pos.x = Random.Range(20f, 200f);
        gameObject.transform.position = new Vector3(100f, pos.y, pos.z);
    }
}
