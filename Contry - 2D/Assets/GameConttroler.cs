using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameConttroler : MonoBehaviour
{
    public Image[] img;

    public Sprite[] country;
    public Sprite[] fieldCountry;

    public void OnSelectCountryUkraine()
    {
        img[0].sprite = country[0];
        img[1].sprite = fieldCountry[1];
        img[2].sprite = fieldCountry[2];
    }

    public void OnSelectCountryMoldova()
    {
        img[0].sprite = fieldCountry[0];
        img[1].sprite = country[1];
        img[2].sprite = fieldCountry[2];
    }

    public void OnSelectCountryRumunia()
    {
        img[0].sprite = fieldCountry[0];
        img[1].sprite = fieldCountry[1];
        img[2].sprite = country[2];
    }
}
