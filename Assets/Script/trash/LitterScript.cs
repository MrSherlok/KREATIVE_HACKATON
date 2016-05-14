using UnityEngine;
using System.Collections;

public class LitterScript : MonoBehaviour {
    private Rigidbody2D rb;
    public float strenghUp;
    public float strenghSide;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
                
        if (HumanScript.m == 1)
        {
            rb.velocity += Random.Range(300f, strenghUp) * Vector2.up;
        } else {
            if (HumanScript.m <= 22) rb.velocity += Random.Range(300f, strenghUp) * Vector2.up;
            else rb.velocity += Random.Range(300f, strenghUp-150f) * Vector2.up;
        }
        if (HumanScript.n <= 45) rb.velocity += Random.Range(100f, strenghSide) * Vector2.right;
        else rb.velocity += Random.Range(150f, strenghSide) * Vector2.left;

    }

}
