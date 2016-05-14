using UnityEngine;
using System.Collections;

public class HumanLittering : MonoBehaviour {
    GameObject human1;
    public Vector3 pos;
    Quaternion rot;
	void ILitter () {
        pos.x = Random.Range(-380f, 380f);

    Instantiate(human1,pos,rot);
    
            }
}
