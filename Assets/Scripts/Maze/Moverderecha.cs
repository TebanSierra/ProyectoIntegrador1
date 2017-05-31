using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Moverderecha : MonoBehaviour {

    public Transform heroobj;
    List<string> lista = new List<string>();
    int tamaño;
    private int cont;
    // Use this for initialization
    void Start() {

    }
    Collision col;
    // Update is called once per frame
    void Update() {
    }
    public void moverderecha() {
        if (true) {
            //heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
           // heroobj.transform.eulerAngles = new Vector3(0, 0, 0);
            lista.Add("Derecha");
            
        }
    }           
    
    public void moverabajo()
    {
        if (true)
        {
           // heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2);
           // heroobj.transform.eulerAngles = new Vector3(0, 0, -90);
            lista.Add("Abajo");
        }
    }
    public void moverizquierda()
    {
        if (true)
        {
           // heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
            //heroobj.transform.eulerAngles = new Vector3(0, 0, 180);
            lista.Add("Izquierda");
        }
    }
    public void moverarriba()
    {
        if (true)
        {
            //heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
           // heroobj.transform.eulerAngles = new Vector3(0, 0, 90);
            lista.Add("Arriba");
        }
    }
    public void empezar()
    {   
        
        StartCoroutine(DoTheDance());
    }
    public void mover(string a)
    {
        if (a == "Arriba")
        {
            heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
            heroobj.transform.eulerAngles = new Vector3(0, 0, 90);
        }else if(a=="Abajo"){
            heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -2);
            heroobj.transform.eulerAngles = new Vector3(0, 0, -90);
        }else if (a == "Izquierda"){
            heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
            heroobj.transform.eulerAngles = new Vector3(0, 0, 180);
        }else if (a == "Derecha")
        {
            heroobj.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
            heroobj.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
    public IEnumerator DoTheDance()
    {
        tamaño = lista.Count;
        for (int i = 0; i < tamaño; i++)
        {
            print("Antes de esperar");
            mover(lista[i]);
            yield return new WaitForSeconds(3f);
            print("despues de esperar");
        }
        lista.Clear();
    }
}



       


    

