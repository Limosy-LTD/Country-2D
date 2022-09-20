using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCountryConttroler : GameConttroler
{
    [Header("Tool - Game")]

    public bool showCountryFlag;
    [Space(2f)]
    public bool seeMod;
    [Space(2f)]
    public bool attackMod;
    [Space(2f)]

    [Header("Country - Attack")]

    public bool ukraineAttack;
    [Space(2f)]
    public bool moldovaAttack;
    [Space(2f)]
    public bool rumaniaAttack;
    [Space(2f)]
    public bool polandAttack;
    [Space(2f)]
    public bool slovakiaAttack;
    [Space(2f)]
    public bool hungaryAttack;
    [Space(5f)]
    public Sprite[] spriteUkraineAllCountry;
    [Space(5f)]
    public Sprite[] spriteMoldovaAllCountry;
    [Space(5f)]
    public Sprite[] spriteRumaniaAllCountry;
    [Space(5f)]
    public Sprite[] spritePolandAllCountry;
    [Space(5f)]
    public Sprite[] spriteSlovakiaAllCountry;
    [Space(5f)]
    public Sprite[] spriteHungaryAllCountry;

    private float attackModID;

    [Header("ButtonSeeAll")]

    public Image buttonSeeAllCountry;
    [Space(2f)]
    public Sprite spriteOnShowCountry;
    [Space(2f)]
    public Sprite spriteOffShowCountry;

    [Header("ButtonSeeMod")]

    public Image buttonSeeMod;
    [Space(2f)]
    public Sprite spriteOnSeeMod;
    [Space(2f)]
    public Sprite spriteOffSeeMod;

    [Header("ButtonDataCountry")]

    public Image buttonDataCountry;
    [Space(2f)]
    public Sprite spriteOnDataCountry;
    [Space(2f)]
    public Sprite spriteOffDataCountry;

    [Header("ButtonAttackCountry")]

    public Image buttonAttack;
    [Space(2f)]
    public Sprite spriteOnAttack;
    [Space(2f)]
    public Sprite spriteOffAttack;

    [Header("GamePanel")]

    public GameObject panUpgrade;
    [Space(2f)]
    public GameObject panDataCountry;
    [Space(2f)]
    public GameObject panAgreeAtack;
    [Space(2f)]
    public GameObject panChat;
    public GameObject loginPanChat;
    [Space(2f)]
    public GameObject WaterPanGame;

    [Header("WarningMassage")]

    public GameObject WarningObject;
    [Space(2f)]
    public Text WarningText;
    [Space(2f)]
    public bool ActiveMessage;
    [Space(2f)]
    public float idMessege;

    [Header("Curensy")]

    public float curencyMoney;
    [Space(2f)]
    public Text curencyText;

    [Header("DataCountryPan")]

    public Image flagCountry;
    [Space(2f)]
    public string[] nameYourCountry;
    [Space(2f)]
    public Sprite[] flagImg;
    [Space(2f)]
    public Text nameYourCountryText;

    [Header("PanelUpgradeSettings")]

    public float[] costUpgradeItem;
    [Space(2f)]
    public Image population;
    [Space(2f)]
    public Image livingZone;
    [Space(2f)]
    public Image industrialZone;
    [Space(2f)]
    public Image entertainmentZone;
    [Space(2f)]
    public Image buildersZone;
    [Space(2f)]
    public float populationFill;
    [Space(2f)]
    public float livingZoneFill;
    [Space(2f)]
    public float industrialZoneFill;
    [Space(2f)]
    public float entertainmentZoneFill;
    [Space(2f)]
    public float buildersZoneFill;
    [Space(2f)]
    public GameObject populationMedal;
    [Space(2f)]
    public GameObject livingZoneMedal;
    [Space(2f)]
    public GameObject industrialZoneMedal;
    [Space(2f)]
    public GameObject entertainmentZoneMedal;
    [Space(2f)]
    public GameObject buildersZoneMedal;

    public Text[] textDataUpgrade; 

    private void Start()
    {
        if (PlayerPrefs.HasKey("ID"))
        {
            idCountry = PlayerPrefs.GetInt("ID");
        }

        if (PlayerPrefs.HasKey("WaterData"))
        {
            WaterData = PlayerPrefs.GetInt("WaterData");
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

        if (WaterData == 1)
        {
            WaterPanGame.SetActive(true);
        }
        else if (WaterData == 0)
        {
            WaterPanGame.SetActive(false);
        }
    }

    public void OnPressUkraine()
    {
        if (seeMod)
        {
            if (ukraineAttack)
            {
                if(idCountry == 1)
                {        
                   img[0].sprite = spriteUkraineAllCountry[0];
                }
                else if (idCountry == 2)
                {
                   img[0].sprite = spriteMoldovaAllCountry[0];
                }
                else if(idCountry == 3)
                {
                   img[0].sprite = spriteRumaniaAllCountry[0];
                }
                else if(idCountry == 4)
                {
                   img[0].sprite = spritePolandAllCountry[0];
                }
                else if(idCountry == 5)
                {
                   img[0].sprite = spriteSlovakiaAllCountry[0];
                }
                else if(idCountry == 6)
                {
                   img[0].sprite = spriteHungaryAllCountry[0];
                }       
            }
            else
            {
                img[0].sprite = fieldCountry[0];
            }

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

            if (moldovaAttack)
            {
                if(idCountry == 1)
                {        
                   img[1].sprite = spriteUkraineAllCountry[1];
                }
                else if (idCountry == 2)
                {
                   img[1].sprite = spriteMoldovaAllCountry[1];
                }
                else if(idCountry == 3)
                {
                   img[1].sprite = spriteRumaniaAllCountry[1];
                }
                else if(idCountry == 4)
                {
                   img[1].sprite = spritePolandAllCountry[1];
                }
                else if(idCountry == 5)
                {
                   img[1].sprite = spriteSlovakiaAllCountry[1];
                }
                else if(idCountry == 6)
                {
                   img[1].sprite = spriteHungaryAllCountry[1];
                }        
            }
            else
            {
                img[1].sprite = fieldCountry[1];
            }

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

            if (rumaniaAttack)
            {
                 if(idCountry == 1)
                {        
                   img[2].sprite = spriteUkraineAllCountry[2];
                }
                else if (idCountry == 2)
                {
                   img[2].sprite = spriteMoldovaAllCountry[2];
                }
                else if(idCountry == 3)
                {
                   img[2].sprite = spriteRumaniaAllCountry[2];
                }
                else if(idCountry == 4)
                {
                   img[2].sprite = spritePolandAllCountry[2];
                }
                else if(idCountry == 5)
                {
                   img[2].sprite = spriteSlovakiaAllCountry[2];
                }
                else if(idCountry == 6)
                {
                   img[2].sprite = spriteHungaryAllCountry[2];
                }     
            }
            else
            {
                img[2].sprite = fieldCountry[2];
            }

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

            if (polandAttack)
            {
                if(idCountry == 1)
                {        
                   img[3].sprite = spriteUkraineAllCountry[3];
                }
                else if (idCountry == 2)
                {
                   img[3].sprite = spriteMoldovaAllCountry[3];
                }
                else if(idCountry == 3)
                {
                   img[3].sprite = spriteRumaniaAllCountry[3];
                }
                else if(idCountry == 4)
                {
                   img[3].sprite = spritePolandAllCountry[3];
                }
                else if(idCountry == 5)
                {
                   img[3].sprite = spriteSlovakiaAllCountry[3];
                }
                else if(idCountry == 6)
                {
                   img[3].sprite = spriteHungaryAllCountry[3];
                }     
            }
            else
            {
                img[3].sprite = fieldCountry[3];
            }

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

            if (slovakiaAttack)
            {
                if(idCountry == 1)
                {        
                   img[4].sprite = spriteUkraineAllCountry[4];
                }
                else if (idCountry == 2)
                {
                   img[4].sprite = spriteMoldovaAllCountry[4];
                }
                else if(idCountry == 3)
                {
                   img[4].sprite = spriteRumaniaAllCountry[4];
                }
                else if(idCountry == 4)
                {
                   img[4].sprite = spritePolandAllCountry[4];
                }
                else if(idCountry == 5)
                {
                   img[4].sprite = spriteSlovakiaAllCountry[4];
                }
                else if(idCountry == 6)
                {
                   img[4].sprite = spriteHungaryAllCountry[4];
                }     
            }
            else
            {
                img[4].sprite = fieldCountry[4];
            }

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

            if (hungaryAttack)
            {
                if(idCountry == 1)
                {        
                   img[5].sprite = spriteUkraineAllCountry[5];
                }
                else if (idCountry == 2)
                {
                   img[5].sprite = spriteMoldovaAllCountry[5];
                }
                else if(idCountry == 3)
                {
                   img[5].sprite = spriteRumaniaAllCountry[5];
                }
                else if(idCountry == 4)
                {
                   img[5].sprite = spritePolandAllCountry[5];
                }
                else if(idCountry == 5)
                {
                   img[5].sprite = spriteSlovakiaAllCountry[5];
                }
                else if(idCountry == 6)
                {
                   img[5].sprite = spriteHungaryAllCountry[5];
                }      
            }
            else
            {
                img[5].sprite = fieldCountry[5];
            }
        }
    }

    public void OnSeeModTurn()
    {
        if (showCountryFlag || attackMod)
        {
            return;
        }

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

    public void OnShowAllCountryFlag()
    {
        if (seeMod || attackMod)
        {
            return;
        }

            if (!showCountryFlag)
            {
               if(ukraineAttack)
               {
                   if (idCountry == 1)
                   {
                       img[0].sprite = spriteUkraineAllCountry[0];
                   }
                   else if (idCountry == 2)
                   {
                       img[0].sprite = spriteMoldovaAllCountry[0]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[0].sprite = spriteRumaniaAllCountry[0]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[0].sprite = spritePolandAllCountry[0]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[0].sprite = spriteSlovakiaAllCountry[0]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[0].sprite = spriteHungaryAllCountry[0]; 
                   }
               }
               else
               {
                   img[0].sprite = fieldCountry[0];
               }

               if(moldovaAttack)
               {
                   if (idCountry == 1)
                   {
                       img[1].sprite = spriteUkraineAllCountry[1];
                   }
                   else if (idCountry == 2)
                   {
                       img[1].sprite = spriteMoldovaAllCountry[1]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[1].sprite = spriteRumaniaAllCountry[1]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[1].sprite = spritePolandAllCountry[1]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[1].sprite = spriteSlovakiaAllCountry[1]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[1].sprite = spriteHungaryAllCountry[1]; 
                   }
               }
               else
               {
                   img[1].sprite = fieldCountry[1];
               }

               if(rumaniaAttack)
               {
                   if (idCountry == 1)
                   {
                       img[2].sprite = spriteUkraineAllCountry[2];
                   }
                   else if (idCountry == 2)
                   {
                       img[2].sprite = spriteMoldovaAllCountry[2]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[2].sprite = spriteRumaniaAllCountry[2]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[2].sprite = spritePolandAllCountry[2]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[2].sprite = spriteSlovakiaAllCountry[2]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[2].sprite = spriteHungaryAllCountry[2]; 
                   }
               }
               else
               {
                   img[2].sprite = fieldCountry[2];
               }

               if(polandAttack)
               {
                   if (idCountry == 1)
                   {
                       img[3].sprite = spriteUkraineAllCountry[3];
                   }
                   else if (idCountry == 2)
                   {
                       img[3].sprite = spriteMoldovaAllCountry[3]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[3].sprite = spriteRumaniaAllCountry[3]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[3].sprite = spritePolandAllCountry[3]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[3].sprite = spriteSlovakiaAllCountry[3]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[3].sprite = spriteHungaryAllCountry[3]; 
                   }
               }
               else
               {
                   img[3].sprite = fieldCountry[3];
               }

               if(slovakiaAttack)
               {
                   if (idCountry == 1)
                   {
                       img[4].sprite = spriteUkraineAllCountry[4];
                   }
                   else if (idCountry == 2)
                   {
                       img[4].sprite = spriteMoldovaAllCountry[4]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[4].sprite = spriteRumaniaAllCountry[4]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[4].sprite = spritePolandAllCountry[4]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[4].sprite = spriteSlovakiaAllCountry[4]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[4].sprite = spriteHungaryAllCountry[4]; 
                   }
               }
               else
               {
                   img[4].sprite = fieldCountry[4];
               }

               if(hungaryAttack)
               {
                   if (idCountry == 1)
                   {
                       img[5].sprite = spriteUkraineAllCountry[5];
                   }
                   else if (idCountry == 2)
                   {
                       img[5].sprite = spriteMoldovaAllCountry[5]; 
                   }
                   else if (idCountry == 3)
                   {
                       img[5].sprite = spriteRumaniaAllCountry[5]; 
                   }
                   else if (idCountry == 4)
                   {
                       img[5].sprite = spritePolandAllCountry[5]; 
                   }
                   else if (idCountry == 5)
                   {
                       img[5].sprite = spriteSlovakiaAllCountry[5]; 
                   }
                   else if (idCountry == 6)
                   {
                       img[5].sprite = spriteHungaryAllCountry[5]; 
                   }
               }
               else
               {
                   img[5].sprite = fieldCountry[5];
               }

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

    public void OnPressAttackMod()
    {
        if (showCountryFlag || seeMod)
        {
            return;
        }

        attackMod = !attackMod;

        if (attackMod)
        {
            buttonAttack.sprite = spriteOnAttack;      
        }
        else if (!attackMod)
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

            buttonAttack.sprite = spriteOffAttack;
        }
    }

    public void OnPressUkraineAttack()
    {
        if (attackMod && idCountry != 1 && !ukraineAttack)
        {
            img[0].sprite = fieldCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 1;
            panAgreeAtack.SetActive(true);
        }
        else if(ukraineAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 1)
        {
            if (!ActiveMessage && idCountry == 1 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressMoldovaAttack()
    {
        if (attackMod && idCountry != 2 && !moldovaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 2;
            panAgreeAtack.SetActive(true);
        }
        else if(moldovaAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 2)
        {
            if (!ActiveMessage && idCountry == 2 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressRumuniaAttack()
    {
        if (attackMod && idCountry != 3 && !rumaniaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = fieldCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 3;
            panAgreeAtack.SetActive(true);
        }
        else if(rumaniaAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 3)
        {
            if (!ActiveMessage && idCountry == 3 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressPolandAttack()
    {
        if (attackMod && idCountry != 4 && !polandAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = fieldCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 4;
            panAgreeAtack.SetActive(true);
        }
        else if(polandAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 4)
        {
            if (!ActiveMessage && idCountry == 4 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressSlovakiaAttack()
    {
        if (attackMod && idCountry != 5 && !slovakiaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = fieldCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 5;
            panAgreeAtack.SetActive(true);
        }
        else if(slovakiaAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 5)
        {
            if (!ActiveMessage && idCountry == 5 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressHungaryAttack()
    {
        if (attackMod && idCountry != 6 && !hungaryAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = fieldCountry[5];

            attackModID = 6;
            panAgreeAtack.SetActive(true);
        }
        else if(hungaryAttack)
        {
            if (!ActiveMessage && attackMod)
            {
                idMessege = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (idCountry == 6)
        {
            if (!ActiveMessage && idCountry == 6 && attackMod)
            {
                idMessege = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressYesAttack()
    {
        if (attackModID == 1)
        {
            img[0].sprite = spriteUkraineAllCountry[0];
            ukraineAttack = true;
        }
        else if (attackModID == 2)
        {
            img[1].sprite = spriteMoldovaAllCountry[1];
            moldovaAttack = true;
        }
        else if (attackModID == 3)
        {
            img[2].sprite = spriteRumaniaAllCountry[2];
            rumaniaAttack = true;
        }
        else if (attackModID == 4)
        {
            img[3].sprite = spritePolandAllCountry[3];
            polandAttack = true;
        }
        else if (attackModID == 5)
        {
            img[4].sprite = spriteSlovakiaAllCountry[4];
            slovakiaAttack = true;
        }
        else if (attackModID == 6)
        {
            img[5].sprite = spriteHungaryAllCountry[5];
            hungaryAttack = true;
        }

        panAgreeAtack.SetActive(false);
    }

    public void OnPressNoAttack()
    {
        panAgreeAtack.SetActive(false);
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
        if (panDataCountry.activeSelf || panChat.activeSelf)
        {
            return;
        }

        panUpgrade.SetActive(!panUpgrade.activeSelf);
    }

    public void OnOpenChat()
    {
        if (panDataCountry.activeSelf || panUpgrade.activeSelf)
        {
            return;
        }

        panChat.SetActive(!panChat.activeSelf);
        loginPanChat.SetActive(!loginPanChat.activeSelf);
    }

    public void OnOpenPanDataCountry()
    {
        if (panUpgrade.activeSelf || panChat.activeSelf)
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

    IEnumerator MessageWarning()
    {
        ActiveMessage = true;

        if(idMessege == 1)
        {
            WarningText.text = "THIS IS YOUR COUNTRY!";
        }
        else if (idMessege == 2)
        {
            WarningText.text = "YOU HAVE ALREADY CONQUERED THIS COUNTRY!";
        }

        WarningObject.SetActive(true);
        yield return new WaitForSeconds(1.4f);
        ActiveMessage = false;
    
        WarningText.text = "Sorry error !";

        WarningObject.SetActive(false);
    }
}
