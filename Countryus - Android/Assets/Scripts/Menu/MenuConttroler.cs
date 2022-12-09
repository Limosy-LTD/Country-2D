using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuConttroler : TextConttroler
{

    [Header("Country")]

    public Image[] img;

    public Sprite[] fieldCountry;
    public Sprite[] linearCountry;

   
    [Header("Game Panel")]

    public GameObject PanelInfo;
    public GameObject PanelNews;
    public GameObject PanelSetting;

    public GameObject PanelBlackout;


    [Header("Game Object")]

    public bool IsBackground;

    public GameObject BackgroundObject;
    public Text BackGroundSettingsText;

    [Header("Data Country")]
    public Text NameCountry;

    public int CountryId;
    public string CountryName;

      
    public void OnSelectCountryUkraine()
    {
        img[0].sprite = fieldCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        CountryId = 1;
        CountryName = "Ukraine";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnSelectCountryMoldova()
    {
        img[0].sprite = linearCountry[0]; 
        img[1].sprite = fieldCountry[1];
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 
        
        CountryId = 2;
        CountryName = "Moldova";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnSelectCountryRumunia()
    {
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1];
        img[2].sprite = fieldCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        CountryId = 3;
        CountryName = "Rumania";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnSelectCountryPoland()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = fieldCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = linearCountry[5]; 

        CountryId = 4;
        CountryName = "Poland";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnSelectCountrySlovakia()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = fieldCountry[4];
        img[5].sprite = linearCountry[5]; 

        CountryId = 5;
        CountryName = "Slovakia";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnSelectCountryHungary()
    { 
        img[0].sprite = linearCountry[0];
        img[1].sprite = linearCountry[1]; 
        img[2].sprite = linearCountry[2]; 
        img[3].sprite = linearCountry[3];
        img[4].sprite = linearCountry[4];
        img[5].sprite = fieldCountry[5]; 

        CountryId = 6;
        CountryName = "Hungary";
        PlayerPrefs.SetInt("ID", CountryId);
    }

    public void OnBackGroundSettings()
    {
        if (IsBackground)
        {
            BackGroundSettingsText.text = "Water - Off";
    
            IsBackground = false;
            BackgroundObject.SetActive(false);
        }

        else if (!IsBackground)
        {
            BackGroundSettingsText.text = "Water - On";

            IsBackground = true;
            BackgroundObject.SetActive(true);
        }
    }

    public void OnClikOpenInfoPanel()
    {
        if (PanelNews.activeSelf || PanelSetting.activeSelf)
        {
            return;
        }

        PanelBlackout.SetActive(!PanelBlackout.activeSelf);
        PanelInfo.SetActive(!PanelInfo.activeSelf);
    }

    public void OnClikOpenNewsPanel()
    {
        if (PanelSetting.activeSelf || PanelInfo.activeSelf)
        {
            return;
        }

        PanelBlackout.SetActive(!PanelBlackout.activeSelf);
        PanelNews.SetActive(!PanelNews.activeSelf);
    }

    public void OnClikOpenSettingsPanel()
    {
        if (PanelInfo.activeSelf || PanelNews.activeSelf)
        {
            return;
        }

        PanelBlackout.SetActive(!PanelBlackout.activeSelf);
        PanelSetting.SetActive(!PanelSetting.activeSelf);
    }

    public void OnClikItchIoWeb()
    {
        Application.OpenURL("https://fanlizor.itch.io/");
    }

    public void OnClikInstagramWeb()
    {
        Application.OpenURL("https://www.instagram.com/arthur_reshetniak/");
    }

    public void OnClikStart()
    {
        if(CountryId == 0)
        {
            Debug.Log("Выбирите страну!");
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
}

