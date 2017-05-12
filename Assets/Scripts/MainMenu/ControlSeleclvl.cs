using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlSeleclvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public Image imagen;
    public void LoadScene(string sceneName)
    {
        StartCoroutine(Lvlsel(sceneName));
        

    }
    public IEnumerator Lvlsel(string sceneName)
    {

        imagen.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        imagen.gameObject.SetActive(false);
        SceneManager.LoadScene(sceneName);

    }
}
