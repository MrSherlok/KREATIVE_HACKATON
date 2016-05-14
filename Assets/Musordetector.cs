using UnityEngine;
using System.Collections;

public class Musordetector : MonoBehaviour {
    GameObject musor;



    void OnTriggerEnter2D(Collider2D mus)
    {
       if (mus.gameObject.tag == "Musor") {
            Debug.Log("wsef");
            musor = mus.gameObject;
            Destroy(musor); 
         }
    }

}
