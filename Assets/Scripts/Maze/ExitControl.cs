using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitControl : MonoBehaviour {
  
    // Use this for initialization
    void Start () {

	}
    public GameObject mensaje;
    public Transform hero;
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.name == "Player")
        {
            StartCoroutine(DoTheDance());
        }
    }
    public IEnumerator DoTheDance()
    {
        mensaje.SetActive(true);
        hero.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(4f);
        mensaje.SetActive(false);
        SceneManager.LoadScene("LevelSelec");


    }
     
}
