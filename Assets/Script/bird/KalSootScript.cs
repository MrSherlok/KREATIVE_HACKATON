using UnityEngine;
using System.Collections;

public class KalSootScript : MonoBehaviour
{
    float _n;
    public GameObject weappPoint;
    Vector3 _pos;
    public GameObject KalPref;



    void Start()
    {
        _n = Random.Range(0.3f, 2f);
        Invoke("Srat", _n);
    }

    void Srat()
    {
        _pos = weappPoint.transform.position;
        Instantiate(KalPref, _pos, Quaternion.identity);
    }
}
