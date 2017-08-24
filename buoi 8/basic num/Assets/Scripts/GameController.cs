using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    public Text displayText;
    public Button lowerButton;
    public Button higherButton;
    public Button correctButton;
    public Button startButton;
    public Button playAgainButton;
    public InputField minInput;
    public InputField maxInput;

    int guessNum;
    int guessCount;
    int guessHigh= 100;
    int guessLow=0;



    // Use this for initialization
    void Start () {
        playAgain();

    }
    public void start()
    {
        guessNum = Random.Range(0, 100);
        displayText.text = "Is it " +guessNum+" ?";
        higherButton.gameObject.SetActive(true);
        lowerButton.gameObject.SetActive(true);
        correctButton.gameObject.SetActive(true);

        startButton.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
        guessCount++;



    }

    public void higher()
    {
        if (guessLow<guessNum)
        {
            guessLow = guessNum;
        }
        guessNum = Random.Range(guessNum, guessHigh);
        displayText.text = "Is it " + guessNum + " ?";
        higherButton.gameObject.SetActive(true);
        lowerButton.gameObject.SetActive(true);
        correctButton.gameObject.SetActive(true);

        startButton.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
        guessCount++;


    }
    public void lower()
    {
        if (guessHigh>guessNum)
        {
            guessHigh = guessNum;
        }
        guessNum = Random.Range(guessLow, guessNum);
        displayText.text = "Is it " + guessNum + " ?";
        higherButton.gameObject.SetActive(true);
        lowerButton.gameObject.SetActive(true);
        correctButton.gameObject.SetActive(true);

        startButton.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
        guessCount++;


    }
    public void correct()
    {
        displayText.text = "Yayy! \nI win! =))), it took me "+guessCount+" times. \nWanna play again?";
        higherButton.gameObject.SetActive(false);
        lowerButton.gameObject.SetActive(false);
        correctButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);

        playAgainButton.gameObject.SetActive(true);



    }


    public void playAgain()
    {
        displayText.text = "Sup! Think about a number, between 0-100, I'm gonna guess it, okay?";
        higherButton.gameObject.SetActive(false);
        lowerButton.gameObject.SetActive(false);
        correctButton.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);

        startButton.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
