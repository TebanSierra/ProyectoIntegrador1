﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public List<Button> buttons = new List<Button>();

    [SerializeField]
    private Button checkPuzzle;
    [SerializeField]
    private Text scoreShow;

    private int correctPuzzles;
    private int currentPuzzles;

    [SerializeField]
    private Color blackColor = Color.black;
    private Color whiteColor = Color.white;

    private bool pressed;
    private int pressedIndex;
    private int totalCheck;
    byte[,] currentPuzzle;
    byte[,] correctPuzzle;
    [SerializeField]
    private GameObject nonogramPuzzle;
    private int puzzleHeight;
    private int puzzleWidth;
    private int puzzleSize;
    [SerializeField]
    private GameObject Win;
    [SerializeField]
    //Variable que contendra la posicion donde sera creado el Juego.
    private Transform canvas;
    private ChosenNonogram chosenGram;

    void Start() {
        getButtons();
        addListener();
        chooseNonogram();
    }

    void chooseNonogram() {
        chosenGram = GetComponent<AddNanogram>().getChosenNonogram();
        puzzleHeight = chosenGram.getTotalHeight();
        puzzleWidth = chosenGram.getTotalSize();
        correctPuzzle = new byte[puzzleHeight, puzzleWidth];
        currentPuzzle = new byte[puzzleHeight, puzzleWidth];
        correctPuzzle = chosenGram.getResult();
        puzzleSize = chosenGram.getPuzzleSize();
    }

    void getButtons() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");
        for (int i = 0; i < objects.Length; i++) {
            buttons.Add(objects[i].GetComponent<Button>());
        }
    }

    void addListener() {
        foreach (Button button in buttons) {
            button.onClick.AddListener(pickPuzzle);
        }
        checkPuzzle.onClick.AddListener(checkAll);
    }

    public void pickPuzzle() {
        totalCheck++;
        int i = 0;
        int x = 0;
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        pressedIndex = int.Parse(name);
        bool pressed = buttons[pressedIndex].GetComponent<Nonogram>().getPressed();
        if (!pressed) {
            buttons[pressedIndex].image.color = blackColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(true);
            i = pressedIndex;
            while (i>11) {
                i=i - 12;
                x++;
            }
            currentPuzzle[x,pressedIndex%puzzleWidth] = 1;
            i = 0;
            if (totalCheck >= puzzleSize) {
                if (samePuzzle()) {
                    StartCoroutine(winer());
                    
                }
            }
        }else {
            buttons[pressedIndex].image.color = whiteColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(false);
            i = pressedIndex;
            while (i > 11) {
                i = i - 12;
                x++;
            }
            currentPuzzle[x, pressedIndex%puzzleWidth] = 0;
            i = 0;
        }
    }

    public void checkAll() {
        if (samePuzzle() == true) {
            correctPuzzles++;
            currentPuzzles++;
            string textscore = "Correcto!";
            scoreShow.GetComponent<Text>().text = textscore;
            StartCoroutine(winer());
        } else {
            currentPuzzles++;
            string textscore = "Try Again!";
            scoreShow.GetComponent<Text>().text = textscore;
            StartCoroutine(winer());
        }
    }

    public IEnumerator winer()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("LevelSelec");


    }

    public bool samePuzzle() {
        bool equal = correctPuzzle.Rank == currentPuzzle.Rank &&
            Enumerable.Range(0, correctPuzzle.Rank).All(dimension => correctPuzzle.GetLength(dimension) == currentPuzzle.GetLength(dimension)) &&
            correctPuzzle.Cast<byte>().SequenceEqual(currentPuzzle.Cast<byte>());

        return equal;
    }
    
}
