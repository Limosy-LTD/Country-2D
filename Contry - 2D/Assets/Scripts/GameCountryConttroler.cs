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

    [Header("ButtonDataCountry")]
    public Image buttonDataCountry;

    public Sprite spriteOnDataCountry;
    public Sprite spriteOffDataCountry;

    [Header("GamePanel")]
    public GameObject panUpgrade;
    public GameObject panDataCountry;

    [Header("AboutCountry")]
    public float people;
    public Text peopleText;

    public float solders;
    public Text soldersText;

    [Header("Curensy")]
    public float curencyMoney;
    public Text dataCurencyMoney;
    public Text curencyText;

    public float[] cost;
    public Text[] costText;

    public float[] plusPeople;
    public Text[] plusPeopleText;

    public float[] plusSolder;
    public Text[] plusSolderText;

    public float minBornSolder;
    public float maxBornSolder;

    [Header("DataCountryPan")]
    public Image flagCountry;
    public string[] nameYourCountry;

    public Sprite[] flagImg;
    public Text nameYourCountryText;


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

            flagCountry.sprite = flagImg[0];
            nameYourCountryText.text = nameYourCountry[0];
        }
        else if(idCountry == 2)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3];

            flagCountry.sprite = flagImg[1];
            nameYourCountryText.text = nameYourCountry[1];
        }
        else if (idCountry == 3)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = fieldCountry[2]; 
            img[3].sprite = linearCountry[3];

            flagCountry.sprite = flagImg[2];
            nameYourCountryText.text = nameYourCountry[2];
        }
        else if (idCountry == 4)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = fieldCountry[3];

            flagCountry.sprite = flagImg[3];
            nameYourCountryText.text = nameYourCountry[3];
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

    private void Update()
    {
        curencyText.text = curencyMoney.ToString();
        
        dataCurencyMoney.text = curencyMoney.ToString();

        peopleText.text = people.ToString();

        soldersText.text = solders.ToString();
    }

    public void OnOpenPanUpgrade()
    {
        if (panDataCountry.activeSelf)
        {
            return;
        }

        panUpgrade.SetActive(!panUpgrade.activeSelf);
    }

    public void OnOpenPanDataCountry()
    {
        if (panUpgrade.activeSelf)
        {
            return;
        }

        if (panDataCountry.activeSelf)
        {
            buttonDataCountry.sprite = spriteOnDataCountry;
        }
        else if (!panDataCountry.activeSelf)
        {
            buttonDataCountry.sprite = spriteOffDataCountry;
        }

        panDataCountry.SetActive(!panDataCountry.activeSelf);
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

    public void OnBuyUpgradeSoder()
    {
        if(curencyMoney >= cost[1])
        {
            curencyMoney -= cost[1];

            cost[1] *= 2;
            costText[1].text = cost[1] + " " + "$";

            solders += plusSolder[0];
            plusSolder[0] *= 2;
            plusSolderText[0].text = "+" + " " + plusSolder[0] + " " + "Solder";

            soldersText.text = solders.ToString();
        }
    }
}
