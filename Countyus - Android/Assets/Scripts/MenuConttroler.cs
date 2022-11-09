using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuConttroler : MonoBehaviour
{
    [Header("Country")]

    public Image[] img;

    public Sprite[] fieldCountry;
    public Sprite[] linearCountry;

   
    [Header("Panel Game")]

    public GameObject PanelUpdate;

    public GameObject PanelSettings;

    public GameObject PanelDark;


    [Header("Game Object")]

    public GameObject WaterObject;

    public Text TextWaterSettings;

    public Text TextBetaFunction;


    [Header("Data")]

    public Text idName;

    public int idCountry;

    public string nameCountry;

    [Space(4f)]

    public int BetaFunctionStatus;

    public int WaterStatus;


    private void Start()
    {
        if (PlayerPrefs.HasKey("WaterData"))
        {
            WaterStatus = PlayerPrefs.GetInt("WaterData");
        }

        if(WaterStatus == 1)
        {
            WaterObject.SetActive(true);
            TextWaterSettings.text = "Water - On";
        }
        else if (WaterStatus == 0)
        {
            WaterObject.SetActive(false);
            TextWaterSettings.text = "Water - Off";
        }

        if (PlayerPrefs.HasKey("BetaFuction"))
        {
            BetaFunctionStatus = PlayerPrefs.GetInt("BetaFuction");
        }
        else
        {
            BetaFunctionStatus = 0;
            TextBetaFunction.text = "Beta Function - Off";
        }

        if(BetaFunctionStatus == 0)
        {
            TextBetaFunction.text = "Beta Function - Off";
        }
        else if (BetaFunctionStatus == 1)
        {
            TextBetaFunction.text = "Beta Function - On";
        }
    }

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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }
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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }
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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }      
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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }
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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }
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

        if(BetaFunctionStatus == 0)
        {
            idName.text = nameCountry;
        }
        else if (BetaFunctionStatus == 1)
        {
            idName.text = nameCountry + " Id: " + idCountry;
        }
    }


    public void OnOpenUpdatePan()
    {
        if (PanelSettings.active)
        {
            return;
        }

        PanelDark.SetActive(!PanelDark.activeSelf);
        PanelUpdate.SetActive(!PanelUpdate.activeSelf);
    }

    public void OnOpenSettingsPan()
    {
        if (PanelUpdate.active)
        {
            return;
        }

        PanelDark.SetActive(!PanelDark.activeSelf);
        PanelSettings.SetActive(!PanelSettings.activeSelf);
    }

    public void OnClikItchIoWeb()
    {
        Application.OpenURL("https://fanlizor.itch.io/");
    }

    public void OnClikInstagramWeb()
    {
        Application.OpenURL("https://www.instagram.com/arthur_reshetniak/");
    }

    public void OnClikWaterChange()
    {
        WaterObject.SetActive(!WaterObject.activeSelf);

        if (!WaterObject.activeSelf)
        {
            TextWaterSettings.text = "Water - Off";
            WaterStatus = 0;

            PlayerPrefs.SetInt("WaterData", WaterStatus);
        }
        else if (WaterObject.activeSelf)
        {
            TextWaterSettings.text = "Water - On";
            WaterStatus = 1;

            PlayerPrefs.SetInt("WaterData", WaterStatus);
        }
    }

    public void OnClikBetaFuction()
    {
        if (BetaFunctionStatus == 1)
        {
            TextBetaFunction.text = "Beta Function - Off";
            BetaFunctionStatus = 0;

            PlayerPrefs.SetInt("BetaFuction", BetaFunctionStatus);
        }
        else if (BetaFunctionStatus == 0)
        {
            TextBetaFunction.text = "Beta Function - On";
            BetaFunctionStatus = 1;

            PlayerPrefs.SetInt("BetaFuction", BetaFunctionStatus);
        }
    }

    public void OnClikStart()
    {
        if(idCountry == 0)
        {
            Debug.Log("Выбирите страну!");
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}

