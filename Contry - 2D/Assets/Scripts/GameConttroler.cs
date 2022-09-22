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
    public GameObject SelectPanel;
    public GameObject UpdatePanel;
    public GameObject SettingsPanel;

    [Header("GameObject")]
    public GameObject WaterObject;
    public int WaterData;

    public Text TitleWaterSettings;

    private void Start()
    {
        if (PlayerPrefs.HasKey("WaterData"))
        {
            WaterData = PlayerPrefs.GetInt("WaterData");
        }

        if(WaterData == 1)
        {
            WaterObject.SetActive(true);
            TitleWaterSettings.text = "Water - On";
        }
        else if (WaterData == 0)
        {
            WaterObject.SetActive(false);
            TitleWaterSettings.text = "Water - Off";
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
        nameCountry = "UKRAINE";
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
        nameCountry = "MOLDOVA";
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
        nameCountry = "RUMANIA";
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
        nameCountry = "POLAND";
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
        nameCountry = "SLOVAKIA";
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
        nameCountry = "HUNGARY";
        PlayerPrefs.SetInt("ID", idCountry);
        idName.text = nameCountry + " " + idCountry;
    }


    public void OnOpenUpdatePan()
    {
        if (SettingsPanel.active)
        {
            return;
        }

        UpdatePanel.SetActive(!UpdatePanel.activeSelf);
    }

    public void OnOpenSettingsPan()
    {
        if (UpdatePanel.active)
        {
            return;
        }

        SettingsPanel.SetActive(!SettingsPanel.activeSelf);
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
            TitleWaterSettings.text = "Water - Off";
            WaterData = 0;

            PlayerPrefs.SetInt("WaterData", WaterData);
        }
        else if (WaterObject.activeSelf)
        {
            TitleWaterSettings.text = "Water - On";
            WaterData = 1;

            PlayerPrefs.SetInt("WaterData", WaterData);
        }
    }

    public void OnClikSelectCounty()
    {
        SelectPanel.SetActive(!SelectPanel.activeSelf);
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

