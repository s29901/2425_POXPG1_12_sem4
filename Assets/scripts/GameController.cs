using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public string mainWord = "default";
    public int livesCount = 10;
    public TextMeshProUGUI mainWordText;
    public TextMeshProUGUI LivesCountText;
    public TextMeshProUGUI messegeText;
    public TMP_InputField inputField;
    
    
    // Start is called before the first frame update
    void Start()
    {
        mainWordText.text = mainWord;
       LivesCountText.text = $"zastalo {livesCount} prob";
       
    }

    public void OnClick()
    {
        Debug.Log($"guzik został kliknięty");
        livesCount = livesCount -1;
        //livesCount -=1;
        //livesCount --; это все одно и то же 
        LivesCountText.text = $"zastało {livesCount} prób";

        if (mainWord == inputField.text)
        {
            messegeText.text = $"Poprawne słowo zostało wpisane";
            return; 
            //koniec mietody
        }
        if (mainWord.Length != inputField.text.Length) 
        {
            messegeText.text = $"liczba liter się nie zgadza";
            return; 
            //koniec mietody
        }
        
        int bullsCount = CountBulls();
        int cowsCount = CountCows();
        messegeText.text = $"Bulls: {bullsCount} and cows: {cowsCount}";
    }

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
