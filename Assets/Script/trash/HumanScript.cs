using UnityEngine;
using System.Collections;

public class HumanScript : MonoBehaviour {
    public GameObject weapPoint;
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    public Vector3 pos;
    
    public static float n;
    public static float m;
    int lit;
    int litt;
	float time;
    public float speed = 0.3f;
    public int countLitter = 4;
    int i = 1;
    Vector3 _currentPosition;

	void Start () {
		time = speed;
	}

    void FixedUpdate()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if ((countLitter > 0) && (time <= 0)) { 
        {
                n = Random.Range(-7f, 7f);
                while (litt == lit)
                {
                    lit = Random.Range(1, 4);
                }
                litt = lit;
                if (gameObject.tag == "h1")
                {
                    m = 100;                 
                    if (n <= 0) gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f);
                    else gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    gameObject.transform.position = new Vector3(n, pos.y, pos.z);
                }
                if (gameObject.tag == "h2")
                {
                    m = Random.Range(-2f, 2f);
					if ((n <= -3) || (n>=3)) { gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0f); pos.x = -7f; }
                    else { gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f); pos.x = 7f; }
                    gameObject.transform.position = new Vector3(pos.x, m, pos.z);

                }
                _currentPosition = weapPoint.transform.position;
				if (lit == 1) {
					Instantiate(trash1, _currentPosition,Quaternion.identity);
				}
				if (lit == 2) {
					Instantiate(trash2, _currentPosition,Quaternion.identity);
				}
				if (lit == 3) {
					Instantiate(trash3, _currentPosition,Quaternion.identity);
				}
                countLitter--;
                time = speed;

                if (countLitter == 1) Destroy(gameObject);
            }
        }
    }


    }