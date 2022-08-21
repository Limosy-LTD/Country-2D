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
    public string nameCountry;
    public int idCountry;

    [Header("PanelGame")]
    public GameObject UpdatePanel;

    public void OnSelectCountryUkraine()
    {
        img[0].sprite = fieldCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        idCountry = 1;
        nameCountry = "Ukraine";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnSelectCountryMoldova()
    {
        img[0].sprite = linearCountry[0]; 
        img[1].sprite = fieldCountry[1];
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 
        
        idCountry = 2;
        nameCountry = "Moldova";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnSelectCountryRumunia()
    {
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1];
        img[2].sprite = fieldCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        idCountry = 3;
        nameCountry = "Rumania";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnSelectCountryPoland()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = fieldCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        idCountry = 4;
        nameCountry = "Poland";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnSelectCountrySlovakia()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = fieldCountry[4];
        img[5].sprite = linearCountry[5]; 

        idCountry = 5;
        nameCountry = "Slovakia";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnSelectCountryHungary()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = fieldCountry[5]; 

        idCountry = 6;
        nameCountry = "Hungary";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }

    public void OnOpenUpdatePan()
    {
        UpdatePanel.SetActive(!UpdatePanel.activeSelf);
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

