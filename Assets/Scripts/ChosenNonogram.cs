using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ChosenNonogram {

    List<string[]> getRows();
    List<string[]> getCol();
    byte[,] getResult();
    int getCols();
    int getRow();
    int getTotalSize();
    int getTotalHeight();
    int getPuzzleSize();
}
