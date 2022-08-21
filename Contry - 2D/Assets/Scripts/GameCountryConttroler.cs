using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCountryConttroler : GameConttroler
{
    private bool showCountryFlag;
    private bool seeMod;
    private bool fildsStart;

    public int FieldGrowMin;
    public int FieldGrowMax;

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

    public float fields;
    public Text fieldsText;

    [Header("Curensy")]
    public float curencyMoney;

    public Text dataCurencyMoney;
    public Text curencyText;

    public float[] cost;
    public Text[] costText;

    public float[] plusUpgradePopulation;
    public Text[] plusUpgradePopulationText;

    public float[] plusUpgradeFields;

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
        
        dataCurencyMoney.text = curencyMoney.ToString();

        peopleText.text = people.ToString();
        soldersText.text = solders.ToString();
        fieldsText.text = fields.ToString();
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

            people += plusUpgradePopulation[0];
            plusUpgradePopulation[0] *= 2;
            plusUpgradePopulationText[0].text = "+" + " " + plusUpgradePopulation[0] + " " + "People";

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

            solders += plusUpgradePopulation[1];
            plusUpgradePopulation[1] *= 2;
            plusUpgradePopulationText[1].text = "+" + " " + plusUpgradePopulation[1] + " " + "Solder";

            soldersText.text = solders.ToString();
        }
    }

    public void OnBuyUpgradeField()
    {
        if(curencyMoney >= cost[2])
        {
            curencyMoney -= cost[2];

            cost[2] *= 2;
            costText[2].text = cost[2] + " " + "$";

            plusUpgradeFields[0] *= 2;

            FieldGrowMin *= 2;
            FieldGrowMax *= 4;

            fieldsText.text = fields.ToString();

            if (!fildsStart)
            {
                StartCoroutine(FieldsGrow());
                fildsStart = true;
            }
        }
    }

    IEnumerator FieldsGrow()
    {
        float RandomGrowFields = Random.Range(FieldGrowMin, FieldGrowMax);

        fields += RandomGrowFields;

        yield return new WaitForSecondsRealtime(20f);
        StartCoroutine(FieldsGrow());
    }
}
