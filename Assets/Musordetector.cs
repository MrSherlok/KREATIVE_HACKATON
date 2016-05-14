using UnityEngine;
using System.Collections;

public class Musordetector : MonoBehaviour {
    GameObject musor;
    void OnTriggerEnter2D(Collider2D mus)
    {
       if (mus.tag == "Musor") {
        
        Debug.Log("I DESTROY");
            musor = mus.gameObject;
            Invoke("Destroyer", 0.3f);

            

         }
    }
    void Destroyer() {
        Destroy(musor);
    }
}
