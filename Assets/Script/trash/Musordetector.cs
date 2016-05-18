using UnityEngine;
using System.Collections;

public class Musordetector : MonoBehaviour {
    GameObject musor;
    public static int litterDel = 0;
    public static int litterMiss = 0;
	//public AudioClip pusll;




    void OnTriggerEnter2D(Collider2D mus)
    {
       if (mus.gameObject.tag == "Musor") {
            Debug.Log("wsef");
            musor = mus.gameObject;
//			gameObject.GetComponent<AudioSource> ().Play (pusll);


            litterDel++;
			Destroy(musor);
         }
    }


		
	

}
