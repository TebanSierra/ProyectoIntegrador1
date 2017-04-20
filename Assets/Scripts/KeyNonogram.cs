using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyNonogram : MonoBehaviour {

    [SerializeField]
    private byte[,] ng = new byte[,] {{ 1,1,1,1,1,1,1,1,1,1,1,1}, 
                                     { 1,1,0,0,0,1,1,1,1,1,1,1},
                                     { 1,0,1,0,0,0,1,1,1,1,1,1},
                                     { 1,0,0,0,0,0,0,0,0,0,0,1},
                                     { 1,0,0,0,0,0,1,1,0,1,0,1},
                                     { 1,1,0,0,0,1,1,1,1,1,1,1},
                                     { 1,1,1,1,1,1,1,1,1,1,1,1} };
    private List<string[]> rows = new List<string[]>();
    private List<string[]> columns = new List<string[]>();
    string[] row0 = new string[] {"", "","1","","","","","","","","",""};
    string[] row1 = new string[] {"","2","1","1","1","2","3","3","3","3","3",""};
    string[] row2 = new string[] {"7","2","1","1","1","2","3","3","2","3","2","7" };
    string[] col0 = new string[] {"","","","","1","",""};
    string[] col1 = new string[] { "", "", "1", "", "2", "", "" };
    string[] col2 = new string[] { "", "2", "1", "1", "1", "2", "" };
    string[] col3 = new string[] { "12", "7", "6", "1", "1", "7", "12" };
    private int columnsNumber = 3;
    private int rowsNumber = 4;
    private int totalsize = 12;
    private int totalHeight = 7;
    private int size = 57;

    public List<string[]> getRows() {
        rows.Add(row0);
        rows.Add(row1);
        rows.Add(row2);
        return rows;
    }

    public List<string[]> getCol() {
        columns.Add(col0);
        columns.Add(col1);
        columns.Add(col2);
        columns.Add(col3);
        return columns;
    }

    public byte[,] getResult() {
        byte[,] result = ng;
        return result;
    }

    public int getCols() {
        return columnsNumber;
    }

    public int getRow() {
        return rowsNumber;
    }

    public int getTotalSize() {
        return totalsize;
    }

    public int getTotalHeight() {
        return totalHeight;
    }

    public int getPuzzleSize() {
        return size;
    }
}
