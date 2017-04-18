using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Volumen switch image on off
    public Image imagen;
    public Sprite[] botones;
    private bool onoff;
    public void mute()
    {
        onoff = !onoff;
        if (onoff){
            imagen.sprite = botones[0];
            AudioListener.pause = true;
        }else{
            imagen.sprite = botones[1];
            AudioListener.pause = false;
        }
    }
}
