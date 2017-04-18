using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaNonogram : MonoBehaviour {

    private byte[,] ng = new byte[7, 12];       

    // Use this for initialization
    void Start () {
        ng[0, 0] = 0; ng[0, 1] = 0; ng[0, 2] = 0;ng[0, 3] = 0;ng[0, 4] = 0;ng[0, 5] = 1;ng[0, 6] = 0;ng[0, 7] = 0;ng[0, 8] = 0;ng[0, 9] = 0;ng[0, 10] = 0;ng[0, 11] = 0;
        ng[1, 0] = 0;ng[1, 1] = 0;ng[1, 2] = 0;ng[1, 3] = 0;ng[1, 4] = 1;ng[1, 5] = 1;ng[1, 6] = 1; ng[1, 7] = 0; ng[1, 8] = 0; ng[1, 9] = 0; ng[1, 10] = 0; ng[1, 11] = 0;
        ng[2, 0] = 0;ng[2, 1] = 0;ng[2, 1] = 0;ng[2, 2] = 0;ng[2, 3] = 1;ng[2, 4] = 1;ng[2, 5] = 1;ng[2, 6] = 1;ng[2, 7] = 1; ng[2, 8] = 0; ng[2, 9] = 0; ng[2, 10] = 0; ng[2, 11] = 0;
        ng[3, 0] = 0;ng[3, 1] = 0;ng[3, 2] = 1;ng[3, 3] = 1;ng[3, 4] = 1;ng[3, 5] = 1;ng[3, 6] = 1;ng[3, 7] = 1;ng[3, 8] = 1; ng[3, 9] = 0; ng[3, 10] = 0; ng[3, 11] = 0;
        ng[4, 0] = 0;ng[4, 1] = 0;ng[4, 2] = 0;ng[4, 3] = 1;ng[4, 4] = 1;ng[4, 5] = 1;ng[4, 6] = 1;ng[4, 7] = 1; ng[4, 8] = 0; ng[4, 9] = 0; ng[4, 10] = 0; ng[4, 11] = 0;
        ng[5, 0] = 0;ng[5, 1] = 0;ng[5, 2]=0;ng[5, 3] = 1;ng[5, 4] = 4;ng[5, 5] = 0;ng[5, 6] = 1;ng[5, 7] = 1; ng[5, 8] = 0; ng[5, 9] = 0; ng[5, 10] = 0; ng[5, 11] = 0;
        ng[6, 0] = 0; ng[6, 1] = 0; ng[6, 2] = 0; ng[6, 3] = 1; ng[6, 4] = 4; ng[6, 5] = 0; ng[6, 6] = 1; ng[6, 7] = 1; ng[6, 8] = 0; ng[6, 9] = 0; ng[6, 10] = 0; ng[6, 11] = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
