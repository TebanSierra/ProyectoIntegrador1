using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DecodingController : MonoBehaviour {

    private List<string[]> listaPalabras = new List<string[]>();
    private string[] palabras1 = { "suma", "matematicas", "estudios", "deportes", "actividades" };
    private string[] palabras2 = { "monitor", "mouse", "torre", "teclado", "audifonos", "parlantes"};
    private string[] palabras3 = { "guitarra", "bateria", "bajo", "piano", "microfono" };
    private string[] palabras4 = { "manzana", "uva", "banano", "pera", "fresa" };
    private string[] palabras5 = { "oso", "perro", "gato", "elefante", "girafa" };
    private string[] palabras;

    [SerializeField]
    private Button confirmButton;
    [SerializeField]
    private Text changedWord;
    [SerializeField]
    private InputField userWord;
    [SerializeField]
    private InputField userNumber;
    [SerializeField]
    private Text forwards;
    [SerializeField]
    private Text backwards;
    [SerializeField]
    private Text changedLetters;
    
    private bool direccion;
    private int ammountChanged;
    private int lettersChanged;
    private string chosenWord;
    private string modifiedWord;
    private string guessWord;
    private int guessNumber;

	// Use this for initialization
	void Start () {
        addListener();
        fillList();
        chooseList();
        chooseWord();
    }

    void addListener() {
        confirmButton.onClick.AddListener(checkWord);
    }

    void checkWord() {
        guessWord = userWord.text;
        string text = userNumber.text;
        guessNumber = IntParseFast(userNumber.text);
        if (guessWord.Equals(chosenWord) && guessNumber == ammountChanged) {
            chooseWord();
        } else {
            Debug.Log("Your word is: " + guessWord + ", Correct word is: " + chosenWord);
            Debug.Log("Your Number is: " + guessNumber.ToString() + ", Correct number is: " + ammountChanged);

        }
        userWord.text = "";
        userNumber.text = "";
    }

    void chooseWord() {
        lettersChanged = Random.Range(0, palabras.Length);
        chosenWord = palabras[lettersChanged];
        ammountChanged = Random.Range(1, 27);
        getForBack();
        changeLetters();
        string toPrint = lettersChanged + " Letras Cambiadas";
        changedLetters.GetComponent<Text>().text = toPrint;
        changedWord.GetComponent<Text>().text = modifiedWord;
    }

    void checkChanges() {
        char[] compare1 = modifiedWord.ToCharArray();
        char[] compare2 = chosenWord.ToCharArray();
        lettersChanged = 0;
        for (int i = 0; i < modifiedWord.Length; i++) {
            if(compare1[i] != compare2[i]) {
                lettersChanged++;
            }
        }
    }

    void changeLetters() {
        char[] word;
        int wordModification = chosenWord.Length / 2;
        lettersChanged = Random.Range(1, wordModification + 1);
        int[] modifications = new int[wordModification];
        for (int i = 0; i < wordModification; i++) {
            modifications[i] = Random.Range(0, chosenWord.Length);
        }
        word = chosenWord.ToCharArray();
        for (int i = 0; i < lettersChanged; i++) {
            char letter = word[modifications[i]];
            int value = (int)letter;
            if (direccion == true) {
                value = value + ammountChanged;
                forwards.enabled = true;
                backwards.enabled = false;
                if (value > 123) {
                    int x = value - 122;
                    value = 96 + x;

                }
            } else {
                value = value - ammountChanged;
                backwards.enabled = true;
                forwards.enabled = false;
                if (value < 97) {
                    int x = 97 - value;
                    value = 123 - x;
                }
            }
            letter = (char)value;
            word[modifications[i]] = letter;
        }
        modifiedWord = new string(word);
        checkChanges();

    }

    void getForBack() {
        int number = Random.Range(0,2);
        direccion = number != 0;
    }

    int IntParseFast(string value) {
        int result = 0;
        for (int i = 0; i < value.Length; i++) {
            char letter = value[i];
            result = 10 * result + (letter - 48);
        }
        return result;
    }

    void fillList() {
        listaPalabras.Add(palabras1);
        listaPalabras.Add(palabras2);
        listaPalabras.Add(palabras3);
        listaPalabras.Add(palabras4);
        listaPalabras.Add(palabras5);
    }

    void chooseList() {
        int picker = Random.Range(0,5);
        palabras = listaPalabras.ElementAt(picker);
    }
}
