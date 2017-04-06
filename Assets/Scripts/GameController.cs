using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public List<Button> buttons = new List<Button>();

    [SerializeField]
    private Color blackColor = Color.black;
    private Color whiteColor = Color.white;

    private bool pressed;
    private int pressedIndex;

    void Start() {
        getButtons();
        addListener();
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
    }

    public void pickPuzzle() {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        pressedIndex = int.Parse(name);
        bool pressed = buttons[pressedIndex].GetComponent<Nonogram>().getPressed();
        if (!pressed) {
            buttons[pressedIndex].image.color = blackColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(true);
        }else {
            buttons[pressedIndex].image.color = whiteColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(false);
        }
    }

    public bool getPressedValue() {
        
        return false;
    }
}
