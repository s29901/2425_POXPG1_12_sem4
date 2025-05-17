using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public string mainWord = "defoult";
    public int livesCount = 3;
    public TextMeshProUGUI textSecretWord;
    public TextMeshProUGUI textLivesCount;
    
    public TMP_InputField inputField;
    public TextMeshProUGUI textSecretWordLength;
    
    // Start is called before the first frame update
    void Start()
    {
        textSecretWord.text = "The secret word is "+ mainWord;
        textLivesCount.text = $"You have {livesCount} lives left";
        textSecretWordLength.text = "The length of the messege is: 5 ";
       
    }

    public void OnClick()
    {
        livesCount = livesCount -1;
        textLivesCount.text = $"You have {livesCount} lives left";
        if (livesCount <= 0)
        {
            
            textSecretWord.text ="The word was: " + mainWord;
            textSecretWordLength.text = "Game over ";
            textLivesCount.text = " You have no lives left";
        }

        if (mainWord == inputField.text)
        {
           textSecretWord.text ="The word was: " + mainWord;
           textSecretWordLength.text = "Congratulations! You win! ";
           textLivesCount.text = "You have" + livesCount +" lives left ";

            //koniec mietody
        }
        if (mainWord.Length != inputField.text.Length) 
        {
            textSecretWord.text = $"Wrong Lenth, try again";
            //koniec mietody
        }
        
        
        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        textSecretWord.text = $"Bulls: {bullsCount} and cows: {cowsCount}";
    }
  /* public void Win()
    {
        
   } */
    public int CountBulls()
    {
        int result = 0;

        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] == inputField.text[i])
            {
                result ++;
            }
        }
        
        return 0;
    }

    public int CountCows()
    {
        int result = 0;
        //return 0;

        for (int i = 0; i < mainWord.Length; i++)
        {
            if (mainWord[i] != inputField.text[i] && mainWord.Contains(inputField.text[i]))
            {
                result++;
            }
        }
        return result;
    }
    
}
