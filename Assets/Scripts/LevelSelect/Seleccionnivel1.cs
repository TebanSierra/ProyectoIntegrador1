using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Seleccionnivel1 : MonoBehaviour {
    public Image imagen;
    private bool activo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     public void nivel(string a)
    {
        StartCoroutine(DoTheDance(a));
    }
    public IEnumerator DoTheDance(string a)
    {
        imagen.gameObject.SetActive(true);
        yield return new WaitForSeconds(15f);
        imagen.gameObject.SetActive(false);
        SceneManager.LoadScene(a);

    }
}
