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

    [Header("Curensy")]
    public float curencyMoney;
    public Text curencyText;

    [Header("DataCountryPan")]
    public Image flagCountry;
    public string[] nameYourCountry;

    public Sprite[] flagImg;
    public Text nameYourCountryText;

    [Header("PanelUpgradeSettings")]
    public float[] costUpgradeItem;

    public Image population;
    public Image livingZone;
    public Image industrialZone;
    public Image entertainmentZone;
    public Image buildersZone;

    public float populationFill;
    public float livingZoneFill;
    public float industrialZoneFill;
    public float entertainmentZoneFill;
    public float buildersZoneFill;

    public GameObject populationMedal;
    public GameObject livingZoneMedal;
    public GameObject industrialZoneMedal;
    public GameObject entertainmentZoneMedal;
    public GameObject buildersZoneMedal;

    public Text[] textDataUpgrade; 

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
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            flagCountry.sprite = flagImg[0];
            nameYourCountryText.text = nameYourCountry[0];
        }
        else if(idCountry == 2)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            flagCountry.sprite = flagImg[1];
            nameYourCountryText.text = nameYourCountry[1];
        }
        else if (idCountry == 3)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = fieldCountry[2]; 
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            flagCountry.sprite = flagImg[2];
            nameYourCountryText.text = nameYourCountry[2];
        }
        else if (idCountry == 4)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = fieldCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            flagCountry.sprite = flagImg[3];
            nameYourCountryText.text = nameYourCountry[3];
        }
        else if (idCountry == 5)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3];
            img[4].sprite = fieldCountry[4];
            img[5].sprite = linearCountry[5];

            flagCountry.sprite = flagImg[4];
            nameYourCountryText.text = nameYourCountry[4];
        }
        else if (idCountry == 6)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1]; 
            img[2].sprite = linearCountry[2]; 
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = fieldCountry[5];

            flagCountry.sprite = flagImg[5];
            nameYourCountryText.text = nameYourCountry[5];
        }
    }

    public void OnPressUkraine()
    {
        if (seeMod)
        {
            img[0].sprite = fieldCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];
        }
    }

    public void OnPressMoldova()
    {
        if (seeMod)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];
        }
    }

    public void OnPressRumunia()
    {
        if (seeMod)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = fieldCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];
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
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];
        }
    }

    public void OnPressSlovakia()
    {
        if (seeMod)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = fieldCountry[4];
            img[5].sprite = linearCountry[5];
        }
    }

    public void OnPressHungary()
    {
        if (seeMod)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = fieldCountry[5];
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
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (idCountry == 2)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = fieldCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (idCountry == 3)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = fieldCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (idCountry == 4)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = fieldCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (idCountry == 5)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = fieldCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (idCountry == 6)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = fieldCountry[5];  
            }
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
               img[4].sprite = fieldCountry[4];
               img[5].sprite = fieldCountry[5];

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
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (idCountry == 2)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = fieldCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }

                else if (idCountry == 3)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = fieldCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (idCountry == 4)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = fieldCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (idCountry == 5)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = fieldCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (idCountry == 6)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = fieldCountry[5];
                }

                showCountryFlag = false;
                buttonSeeAllCountry.sprite = spriteOnShowCountry;
            }
        }
    }

    private void Update()
    {
        curencyText.text = curencyMoney.ToString();

        textDataUpgrade[0].text = "Population - " + population.fillAmount;
        textDataUpgrade[1].text = "Living Zone - " + livingZone.fillAmount;
        textDataUpgrade[2].text = "Industrial Zone - " + industrialZone.fillAmount;
        textDataUpgrade[3].text = "Entertainment Zone - " + entertainmentZone.fillAmount;
        textDataUpgrade[4].text = "Builders Zone - " + buildersZone.fillAmount;

        if (population.fillAmount >= 1f)
        {
             textDataUpgrade[0].text = "Population - " + population.fillAmount + " Completed";
        }

        if (livingZone.fillAmount >= 1f)
        {
             textDataUpgrade[1].text = "Living Zone - " + livingZone.fillAmount + " Completed";
        }

        if (industrialZone.fillAmount >= 1f)
        {
             textDataUpgrade[2].text = "Industrial Zone - " + industrialZone.fillAmount + " Completed";
        }

        if (entertainmentZone.fillAmount >= 1f)
        {
             textDataUpgrade[3].text = "Entertainment Zone - " + entertainmentZone.fillAmount + " Completed";
        }

        if (buildersZone.fillAmount >= 1f)
        {
            textDataUpgrade[4].text = "Builders Zone - " + buildersZone.fillAmount + " Completed";
        }
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

    public void OnPressBuyUpgradePopulation()
    {
        if (curencyMoney >= costUpgradeItem[0])
        {
            if (population.fillAmount >= 1f)
            {
                populationMedal.SetActive(true);
                return;
            }

            curencyMoney -= costUpgradeItem[0];

            population.fillAmount += populationFill;
        }
    }

    public void OnPressBuyUpgradeLivingZone()
    {
        if (curencyMoney >= costUpgradeItem[1])
        {
            if (livingZone.fillAmount >= 1f)
            {
                livingZoneMedal.SetActive(true);
                return;
            }

            curencyMoney -= costUpgradeItem[1];

            livingZone.fillAmount += livingZoneFill;
        }
    }

    public void OnPressBuyUpgradeIndustrialZone()
    {
        if (curencyMoney >= costUpgradeItem[2])
        {
            if (industrialZone.fillAmount >= 1f)
            {
                industrialZoneMedal.SetActive(true);
                return;
            }

            curencyMoney -= costUpgradeItem[2];

            industrialZone.fillAmount += industrialZoneFill;
        }
    }

    public void OnPressBuyUpgradeEntertainmentZone()
    {
        if (curencyMoney >= costUpgradeItem[3])
        {
            if (entertainmentZone.fillAmount >= 1f)
            {
                entertainmentZoneMedal.SetActive(true);
                return;
            }

            curencyMoney -= costUpgradeItem[3];

            entertainmentZone.fillAmount += entertainmentZoneFill;
        }
    }

    public void OnPressBuyUpgradeBuilderZone()
    {
        if (curencyMoney >= costUpgradeItem[4])
        {
            if (buildersZone.fillAmount >= 1f)
            {
                buildersZoneMedal.SetActive(true);
                return;
            }

            curencyMoney -= costUpgradeItem[4];

            buildersZone.fillAmount += buildersZoneFill;
        }
    }
}
