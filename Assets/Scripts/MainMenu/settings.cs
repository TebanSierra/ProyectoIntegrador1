using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Image imagen;
    private bool activo;
    public void setings(){
        activo = !activo;
        if (activo){
            imagen.gameObject.SetActive(true);
        }else{
            imagen.gameObject.SetActive(false);
        }
    }
}
