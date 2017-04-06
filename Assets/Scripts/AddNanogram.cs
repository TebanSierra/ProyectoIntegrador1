using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNanogram : MonoBehaviour {

    //Serialize permite que la variable pueda ser modificada en Unity sin necesidad de que esta sea Publica. (To simplify things, not having to call them through code)
    [SerializeField]
    //Variable que contendra la posicion donde sera creado el Juego.
    private Transform nonogramField;

    [SerializeField]
    private GameObject nonogramPiece;

    [SerializeField]
    private GameObject hints;

    [SerializeField]
    private int nonogramSize;
    private int nonogramHeight;
    private int monogramWidth;
    

    private byte[,] puzzle;

    //Funcion que es llamada cuando se inica el juego
    void Awake() {
        int x = 0;
        int m = 0;
        while (x<nonogramSize) {
            
            for (int i = 0; i < 4; i++) {
                m = 0;
                m = int.Parse(x.ToString() + i.ToString());
                switch (m) {
                    case 3:
                        hints.GetComponent<Text>().text = "12";
                        break;
                    case 122:
                        hints.GetComponent<Text>().text = "2";
                        break;
                    case 123:
                        hints.GetComponent<Text>().text = "7";
                        break;
                    case 241:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 242:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 243:
                        hints.GetComponent<Text>().text = "6";
                        break;
                    case 362:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 363:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 480:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 481:
                        hints.GetComponent<Text>().text = "2";
                        break;
                    case 482:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 483:
                        hints.GetComponent<Text>().text = "1";
                        break;
                    case 602:
                        hints.GetComponent<Text>().text = "2";
                        break;
                    case 603:
                        hints.GetComponent<Text>().text = "7";
                        break;
                    case 723:
                        hints.GetComponent<Text>().text = "12";
                        break;
                    default:
                        hints.GetComponent<Text>().text = "";
                        break;
                }
                GameObject text = Instantiate(hints);
                text.name = m.ToString();
                text.transform.SetParent(nonogramField, false);


            }
            for (int i = 0; i < 12; i++) {
                GameObject piece = Instantiate(nonogramPiece);
                piece.name = x.ToString();
                piece.transform.SetParent(nonogramField, false);
                x++;
            }
        }
    }


    void setPuzzle(byte[,] puzzle) {
        int width = puzzle.GetLength(1);
        int heigth = puzzle.GetLength(0);
        this.puzzle = new byte[heigth+(heigth/2), width+(width/2)];
    }
}
