using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCountryConttroler : GameConttroler
{
    private bool showCountryFlag;
    private bool seeMod;

    [Header("ButtonSeeAll")]
    public Image buttonSeeAllCountry;

    public Sprite spriteOnShowCountry;
    public Sprite spriteOffShowCountry;

    [Header("ButtonSeeMod")]
    public Image buttonSeeMod;

    public Sprite spriteOnSeeMod;
    public Sprite spriteOffSeeMod;

    [Header("GamePanel")]
    public GameObject panUpgrade;

    [Header("AboutCountry")]
    public float people;
    public Text peopleText;

    public float solders;
    public Text soldersText;

    [Header("Curensy")]
    public float curencyMoney;

    public float[] cost;
    public Text[] costText;

    public float[] plusPeople;
    public Text[] plusPeopleText;

    public float[] plusSolder;
    public Text[] plusSolderText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("ID"))
        {
            idCountry = PlayerPrefs.GetInt("ID");
        }

        if(idCountry == 1)
        {
            img[0].sprite = fieldCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3]; 
        }
        else if(idCountry == 2)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3]; 
        }
        else if (idCountry == 3)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = fieldCountry[2]; 
            img[3].sprite = linearCountry[3]; 
        }
        else if (idCountry == 4)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = fieldCountry[3]; 
        }
    }

    public void OnPressUkraine()
    {
        if(seeMod)
        {
            img[0].sprite = fieldCountry[0]; 
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3];
        }
    }

    public void OnPressMoldova()
    {
        if(seeMod)
        {
           img[0].sprite = linearCountry[0]; 
           img[1].sprite = fieldCountry[1];
           img[2].sprite = linearCountry[2]; 
           img[3].sprite = linearCountry[3];
        }
    }

    public void OnPressRumunia()
    {
        if(seeMod)
        {
           img[0].sprite = linearCountry[0];
           img[1].sprite = linearCountry[1];
           img[2].sprite = fieldCountry[2]; 
           img[3].sprite = linearCountry[3];
        }
    }

    public void OnPressPoland()
    {
        if (seeMod)
        {
           img[0].sprite = linearCountry[0];
           img[1].sprite = linearCountry[1];
           img[2].sprite = linearCountry[2]; 
           img[3].sprite = fieldCountry[3];
        }
    }

    public void OnSeeModTurn()
    {
        if (!showCountryFlag)
        {
            seeMod =!seeMod;

            if (seeMod)
            {
               buttonSeeMod.sprite = spriteOnSeeMod;
            }
            else if (!seeMod)
            {
               buttonSeeMod.sprite = spriteOffSeeMod;
            }

            if(idCountry == 1)
            {   
               img[0].sprite = fieldCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];  
            }
            else if (idCountry == 2)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = fieldCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3]; 
            }
            else if (idCountry == 3)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = fieldCountry[2]; 
               img[3].sprite = linearCountry[3]; 
            }
            else if (idCountry == 4)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = fieldCountry[3];
            }
        }
        else
        {
            return;
        }
    }

    public void OnShowAllCountryFlag()
    {
        if (!seeMod)
        {
            if (!showCountryFlag)
            {   
               img[0].sprite = fieldCountry[0];
               img[1].sprite = fieldCountry[1];
               img[2].sprite = fieldCountry[2]; 
               img[3].sprite = fieldCountry[3];

               showCountryFlag = true;
               buttonSeeAllCountry.sprite = spriteOffShowCountry;
            }
            else if (showCountryFlag)
            {
                if(idCountry == 1)
                {   
                   img[0].sprite = fieldCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];  
                }
                else if (idCountry == 2)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = fieldCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3]; 
                }

                else if (idCountry == 3)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = fieldCountry[2]; 
                   img[3].sprite = linearCountry[3];
                }
                else if (idCountry == 4)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = fieldCountry[3]; 
                }

                showCountryFlag = false;
                buttonSeeAllCountry.sprite = spriteOnShowCountry;
            }
        }
    }

    public void OnOpenPanUpgrade()
    {
        panUpgrade.SetActive(!panUpgrade.activeSelf);
    }

    public void OnBuyUpgradePeople()
    {
        if(curencyMoney >= cost[0])
        {
            curencyMoney -= cost[0];

            cost[0] *= 2;
            costText[0].text = cost[0] + " " + "$";

            people += plusPeople[0];
            plusPeople[0] *= 2;
            plusPeopleText[0].text = "+" + " " + plusPeople[0] + " " + "People";

            peopleText.text = people.ToString();
        }
    }
}
