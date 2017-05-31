using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Transform heroobj;
    // Update is called once per frame
    void Update () {
		
	}
    int a = 0;
    void OnTriggerEnter2D(Collider2D o)
    {
        if (a == 0)
        {
            if (o.name == "Player")
            {
                heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                a++;
            }
        }
    }
}
