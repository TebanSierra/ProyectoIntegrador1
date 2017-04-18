using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNonogram : MonoBehaviour {

    private byte[,] ng = new byte[7, 12];

    // Use this for initialization
    void Start () {
        ng[0, 0] = 1; ng[0, 1] = 1; ng[0, 2] = 1; ng[0, 3] = 1; ng[0, 3] = 1; ng[0, 4] = 1; ng[0, 5] = 1; ng[0, 6] = 1; ng[0, 7] = 1; ng[0, 8] = 1; ng[0, 9] = 1; ng[0, 10] = 1; ng[0, 11] = 1;
        ng[1, 0] = 1; ng[1, 1] = 1; ng[1, 2] = 0; ng[1, 3] = 0; ng[1, 3] = 0; ng[1, 4] = 1; ng[1, 5] = 1; ng[1, 6] = 1; ng[1, 7] = 1; ng[1, 8] = 1; ng[1, 9] = 1; ng[1, 10] = 1; ng[1, 11] = 1;
        ng[2, 0] = 1; ng[2, 1] = 0; ng[2, 2] = 1; ng[2, 3] = 0; ng[2, 3] = 0; ng[2, 4] = 0; ng[2, 5] = 1; ng[2, 6] = 1; ng[2, 7] = 1; ng[2, 8] = 1; ng[2, 9] = 1; ng[2, 10] = 1; ng[2, 11] = 1;
        ng[3, 0] = 1; ng[3, 1] = 0; ng[3, 2] = 0; ng[3, 3] = 0; ng[3, 3] = 0; ng[3, 4] = 0; ng[3, 5] = 0; ng[3, 6] = 0; ng[3, 7] = 0; ng[3, 8] = 0; ng[3, 9] = 0; ng[3, 10] = 0; ng[2, 11] = 1;
        ng[4, 0] = 1; ng[4, 1] = 0; ng[4, 2] = 0; ng[4, 3] = 0; ng[4, 3] = 0; ng[4, 4] = 0; ng[4, 5] = 0; ng[4, 6] = 1; ng[4, 7] = 1; ng[4, 8] = 0; ng[4, 9] = 1; ng[4, 10] = 0; ng[4, 11] = 1;
        ng[5, 0] = 1; ng[5, 1] = 1; ng[5, 2] = 0; ng[5, 3] = 0; ng[5, 3] = 0; ng[5, 4] = 0; ng[5, 5] = 1; ng[5, 6] = 1; ng[5, 7] = 1; ng[5, 8] = 1; ng[5, 9] = 1; ng[5, 10] = 1; ng[5, 11] = 1;
        ng[6, 0] = 1; ng[6, 1] = 1; ng[6, 2] = 1; ng[6, 3] = 1; ng[6, 3] = 1; ng[6, 4] = 1; ng[6, 5] = 1; ng[6, 6] = 1; ng[6, 7] = 1; ng[6, 8] = 1; ng[6, 9] = 1; ng[6, 10] = 1; ng[6, 11] = 1;
    }
}
