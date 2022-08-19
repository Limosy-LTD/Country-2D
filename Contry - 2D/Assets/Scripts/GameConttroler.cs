using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameConttroler : MonoBehaviour
{
    [Header("Country")]

    public Image[] img;

    [Header("CountryImg")]

    public Sprite[] fieldCountry;
    public Sprite[] linearCountry;

    public Text idName;
    public string NmCountry;
    public int idCountry;

    public void OnSelectCountryUkraine()
    {
        img[0].sprite = fieldCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3]; 

        idCountry = 1;
        NmCountry = "Ukraine";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = NmCountry + " " + idCountry;
    }

    public void OnSelectCountryMoldova()
    {
        img[0].sprite = linearCountry[0]; 
        img[1].sprite = fieldCountry[1];
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        
        idCountry = 2;
        NmCountry = "Moldova";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = NmCountry + " " + idCountry;
    }

    public void OnSelectCountryRumunia()
    {
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1];
        img[2].sprite = fieldCountry[2]; 
        img[3].sprite = linearCountry[3];

        idCountry = 3;
        NmCountry = "Rumania";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = NmCountry + " " + idCountry;
    }

    public void OnSelectCountryPoland()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = fieldCountry[3];

        idCountry = 4;
        NmCountry = "Poland";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = NmCountry + " " + idCountry;
    }

    public void OnClikStart()
    {
        if(idCountry == 0)
        {
            Debug.Log("Выбирите страну!");
        }
        else
        { 
            SceneManager.LoadScene("Game");
        }
    }
}

