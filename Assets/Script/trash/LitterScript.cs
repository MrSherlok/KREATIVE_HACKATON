using UnityEngine;
using System.Collections;

public class LitterScript : MonoBehaviour {
    private Rigidbody2D rb;
    public float strenghUp;
    public float strenghSide;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
                
        if (HumanScript.m == 100)
        {
            rb.velocity += Random.Range(10f, strenghUp) * Vector2.up;
			if ( HumanScript.n<=0) rb.velocity += Random.Range(7f, strenghSide) * Vector2.right;
			else rb.velocity += Random.Range(7f, strenghSide) * Vector2.left;
        } else {
			if (HumanScript.m <= -0.5f) rb.velocity += Random.Range(10f, strenghUp) * Vector2.up;
            else rb.velocity += Random.Range(5f, strenghUp-5f) * Vector2.up;
        
			if ((HumanScript.n <= -3) || (HumanScript.n>=3)) rb.velocity += Random.Range(7f, strenghSide-3f) * Vector2.right;
        else rb.velocity += Random.Range(7f, strenghSide-2f) * Vector2.left;
		}
    }

	void Update () {
		gameObject.transform.Rotate(new Vector3 (0, 0, Random.Range(400,800)) * Time.deltaTime,Space.Self);
	}

}
