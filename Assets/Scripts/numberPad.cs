using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberPad : MonoBehaviour
{
    public GameObject checkButtonObject;
    public Light statusLight;
    public static string numberPassword;
    public string currentNumber;
    public TextMesh firstNumberText;
    public TextMesh secondNumberText;
    public TextMesh thirdNumberText;

    public TextMesh testText;
    public TextMesh currentCounter;
    public TextMesh open;
    
    static string firstNumber;
    static string secondNumber;
    static string thirdNumber;
    public TextMesh firstNumberTest;
    public TextMesh secondNumberTest;
    public TextMesh thirdNumberTest;

    static int counter = 0;

    bool correct = false;
    // Start is called before the first frame update
    void Start()
    {
        //currentNumber = numberPassword;   
    }

    // Update is called once per frame
    void Update()
    {
        if (checkButton.buttonCheck == true)
        {
            correct = false;
            checkButton.buttonCheck = false;
            //checkButtonObject.SetActive(false);
            counter = 0;
            firstNumberText.text = "";
            secondNumberText.text = "";
            thirdNumberText.text = "";
            firstNumber = "";
            secondNumber = "";
            thirdNumber = "";
        }
        if (counter > 2 && correct == false)
        {
            checkButtonObject.SetActive(true);
        }
        if (firstNumber == "1" && secondNumber == "1" && thirdNumber == "5")
        {
            winCondition.passwordState = true;
            correct = true;
            
            checkButtonObject.SetActive(false);
            statusLight.enabled = true;
            open.text = "Open = True";
        }
    }
    public void passWord()
    {
       
        counter += 1;
        if(counter == 1)
        {
           
            firstNumberText.text = currentNumber;
            firstNumber = currentNumber;
            
        }
         if (counter == 2)
        {

            secondNumberText.text = currentNumber;
            secondNumber = currentNumber;
            
        }
         if (counter == 3)
        {

            thirdNumberText.text = currentNumber;
            thirdNumber = currentNumber;
            

        }
        
        

        


        firstNumberTest.text = "First Number " + firstNumber;
        secondNumberTest.text = "Second Number " + secondNumber;
        thirdNumberTest.text = "Third Number " + thirdNumber;
        numberPassword = currentNumber;
        testText.text = currentNumber;
        currentCounter.text = counter.ToString();
    }
}
