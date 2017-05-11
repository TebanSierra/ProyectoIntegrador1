using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNonogram : MonoBehaviour, ChosenNonogram  {

    private byte[,] ng = new byte[,] {{ 0,0,0,0,0,0,1,1,1,1},
                                      { 0,0,0,1,1,1,0,0,0,1},
                                      { 0,0,0,1,0,0,0,1,1,1},
                                      { 0,0,0,1,1,1,1,0,0,1},
                                      { 0,0,0,1,0,0,0,0,0,1},
                                      { 0,0,0,1,0,0,0,1,1,1},
                                      { 0,1,1,1,0,0,1,1,1,1},
                                      { 1,1,1,1,0,0,1,1,1,1},
                                      { 1,1,1,1,0,0,0,1,1,0},
                                      { 0,1,1,0,0,0,0,0,0,0}};
    private List<string[]> rows = new List<string[]>();
    private List<string[]> columns = new List<string[]>();
    string[] row0 = new string[] { "", "", "", "", "", "", "1", "1", "1", "" };
    string[] row1 = new string[] { "", "", "", "", "1", "1", "1", "1", "1", "" };
    string[] row2 = new string[] { "2", "4", "4", "8", "1", "1", "2", "4", "4", "8" };
    string[] col0 = new string[] { "", "3", "1", "4", "1", "1", "3", "4", "4", "" };
    string[] col1 = new string[] { "4", "1", "3", "1", "1", "3", "4", "4", "2", "2" };
    private int columnsNumber = 3;
    private int rowsNumber = 2;
    private int totalsize = 10;
    private int totalHeight = 10;
    private int size = 46;

    public List<string[]> getRows() {
        rows.Add(row0);
        rows.Add(row1);
        rows.Add(row2);
        return rows;
    }

    public List<string[]> getCol() {
        columns.Add(col0);
        columns.Add(col1);
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
