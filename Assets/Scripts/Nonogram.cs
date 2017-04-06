using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nonogram : MonoBehaviour {
    private bool pressed = false;

    public void setPressed(bool pressed) {
        this.pressed = pressed;
    }

    public bool getPressed() {
        return pressed;
    }
}
