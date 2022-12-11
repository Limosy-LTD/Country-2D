using System.Collections;
using System.Collections.Generic;
using UnityEngine;   
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameConttroler : MenuConttroler
{
    [Header("Curensy")]

    public float curency;

    public Text curencyText;


    [Header("Tool Game")]

    public bool ShowAllFlagCountry;

    public bool SeeFunction;

    public bool AttackFunction;

    [Space(8f)]

    public int spendCurency;


    [Header("Game Panel")]

    public GameObject PanelMenu;

    public GameObject PanelWater;

    public GameObject PanelAttack;

    public GameObject PanelUpgrade;

    public GameObject PanelTask;

    public GameObject PanelCountryInformation;

    public GameObject PanelChat;

    public GameObject PanelChatLogin;

    public GameObject PanelChatInformation;

    public GameObject PanelDevoleperFunctions;

    public GameObject PanelDark;


    [Header("Help Message")]

    public GameObject HelpMessage;

    public Text HelpMessageText;

    private float HelpMessageId;

    private bool ActiveHelpMessage;


    [Header("Country Info Attack")]

    public bool UkraineAttack;

    public bool MoldovaAttack;

    public bool RumaniaAttack;

    public bool PolandAttack;

    public bool SlovakiaAttack;

    public bool HungaryAttack;

    [Space(10f)]

    public Sprite[] SpriteUkraine;

    public Sprite[] SpriteMoldova;

    public Sprite[] SpriteRumania;

    public Sprite[] SpritePoland;

    public Sprite[] SpriteSlovakia;

    public Sprite[] SpriteHungary;

    private float attackModID;


    [Header("Task Functions")]

    public string[] Task;

    public Text[] TaskText;

    [Space(6f)]

    public float[] Revenue;


    [Header("Beta Functions")]

    public GameObject ButtonFunctionSettings;

    [Space(4f)]

    public Button BetaButtonTask;

    public GameObject BetaTaskIndicator;

    [Space(4f)]

    public int IntCurensy;

    public InputField CurensyIntField;

    [Space(4f)]

    public int IntCurensyErase;

    public InputField CurensyIntFieldErase;

    [Space(4f)]

    public Toggle UkraineAttackFunction;

    public Toggle MoldovaAttackFunction;

    public Toggle RumaniaAttackFunction;

    public Toggle PolandAttackFunction;

    public Toggle SlovakiaAttackFunction;

    public Toggle HungaryAttackFunction;


    [Header("ButtonSeeAll")]

    [Space(8f)]
    public Image buttonSeeAllCountry;
    [Space(2f)]
    public Sprite spriteOnShowCountry;
    [Space(2f)]
    public Sprite spriteOffShowCountry;

    [Header("ButtonSeeMod")]

    [Space(8f)]
    public Image buttonSeeMod;
    [Space(2f)]
    public Sprite spriteOnSeeMod;
    [Space(2f)]
    public Sprite spriteOffSeeMod;

    [Header("ButtonDataCountry")]

    [Space(8f)]
    public Image buttonDataCountry;
    [Space(2f)]
    public Sprite spriteOnDataCountry;
    [Space(2f)]
    public Sprite spriteOffDataCountry;

    [Header("AttackCountry")]

    [Space(8f)]
    public Button AttackYes;
    public Button AttackNo;
    [Space(2f)]
    public Image buttonAttack;
    [Space(2f)]
    public Sprite spriteOnAttack;
    [Space(2f)]
    public Sprite spriteOffAttack;
    [Space(2f)]
    public Text TextProcent;
    [Space(2f)]
    public int ProcentAttack;
    [Space(2f)]
    public bool IsAttack;
    [Space(2f)]
    public float SpeedAttack;
    [Space(4f)]
    public Text AttackData;
    [Space(4f)]
    public int randMoney;
    [Space(4f)]
    public int rand;

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
            CountryId = PlayerPrefs.GetInt("ID");
        }

        if(CountryId == 1)
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
        else if(CountryId == 2)
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
        else if (CountryId == 3)
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
        else if (CountryId == 4)
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
        else if (CountryId == 5)
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
        else if (CountryId == 6)
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

        TaskText[0].text = Task[0];
        TaskText[1].text = Task[1];
        TaskText[2].text = Task[2];
        TaskText[3].text = Task[3];
        TaskText[4].text = Task[4];
    }

    public void OnPressUkraine()
    {
        if (SeeFunction)
        {
            if (UkraineAttack)
            {
                if(CountryId == 1)
                {        
                   img[0].sprite = SpriteUkraine[0];
                }
                else if (CountryId == 2)
                {
                   img[0].sprite = SpriteMoldova[0];
                }
                else if(CountryId == 3)
                {
                   img[0].sprite = SpriteRumania[0];
                }
                else if(CountryId == 4)
                {
                   img[0].sprite = SpritePoland[0];
                }
                else if(CountryId == 5)
                {
                   img[0].sprite = SpriteSlovakia[0];
                }
                else if(CountryId == 6)
                {
                   img[0].sprite = SpriteHungary[0];
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
        if (SeeFunction)
        {
           img[0].sprite = linearCountry[0];

            if (MoldovaAttack)
            {
                if(CountryId == 1)
                {        
                   img[1].sprite = SpriteUkraine[1];
                }
                else if (CountryId == 2)
                {
                   img[1].sprite = SpriteMoldova[1];
                }
                else if(CountryId == 3)
                {
                   img[1].sprite = SpriteRumania[1];
                }
                else if(CountryId == 4)
                {
                   img[1].sprite = SpritePoland[1];
                }
                else if(CountryId == 5)
                {
                   img[1].sprite = SpriteSlovakia[1];
                }
                else if(CountryId == 6)
                {
                   img[1].sprite = SpriteHungary[1];
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
        if (SeeFunction)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];

            if (RumaniaAttack)
            {
                 if(CountryId == 1)
                {        
                   img[2].sprite = SpriteUkraine[2];
                }
                else if (CountryId == 2)
                {
                   img[2].sprite = SpriteMoldova[2];
                }
                else if(CountryId == 3)
                {
                   img[2].sprite = SpriteRumania[2];
                }
                else if(CountryId == 4)
                {
                   img[2].sprite = SpritePoland[2];
                }
                else if(CountryId == 5)
                {
                   img[2].sprite = SpriteSlovakia[2];
                }
                else if(CountryId == 6)
                {
                   img[2].sprite = SpriteHungary[2];
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
        if (SeeFunction)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];

            if (PolandAttack)
            {
                if(CountryId == 1)
                {        
                   img[3].sprite = SpriteUkraine[3];
                }
                else if (CountryId == 2)
                {
                   img[3].sprite = SpriteMoldova[3];
                }
                else if(CountryId == 3)
                {
                   img[3].sprite = SpriteRumania[3];
                }
                else if(CountryId == 4)
                {
                   img[3].sprite = SpritePoland[3];
                }
                else if(CountryId == 5)
                {
                   img[3].sprite = SpriteSlovakia[3];
                }
                else if(CountryId == 6)
                {
                   img[3].sprite = SpriteHungary[3];
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
        if (SeeFunction)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];

            if (SlovakiaAttack)
            {
                if(CountryId == 1)
                {        
                   img[4].sprite = SpriteUkraine[4];
                }
                else if (CountryId == 2)
                {
                   img[4].sprite = SpriteMoldova[4];
                }
                else if(CountryId == 3)
                {
                   img[4].sprite = SpriteRumania[4];
                }
                else if(CountryId == 4)
                {
                   img[4].sprite = SpritePoland[4];
                }
                else if(CountryId == 5)
                {
                   img[4].sprite = SpriteSlovakia[4];
                }
                else if(CountryId == 6)
                {
                   img[4].sprite = SpriteHungary[4];
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
        if (SeeFunction)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];

            if (HungaryAttack)
            {
                if(CountryId == 1)
                {        
                   img[5].sprite = SpriteUkraine[5];
                }
                else if (CountryId == 2)
                {
                   img[5].sprite = SpriteMoldova[5];
                }
                else if(CountryId == 3)
                {
                   img[5].sprite = SpriteRumania[5];
                }
                else if(CountryId == 4)
                {
                   img[5].sprite = SpritePoland[5];
                }
                else if(CountryId == 5)
                {
                   img[5].sprite = SpriteSlovakia[5];
                }
                else if(CountryId == 6)
                {
                   img[5].sprite = SpriteHungary[5];
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
        if (ShowAllFlagCountry || AttackFunction)
        {
            return;
        }

        SeeFunction =!SeeFunction;

            if (SeeFunction)
            {
               buttonSeeMod.sprite = spriteOnSeeMod;
            }
            else if (!SeeFunction)
            {
               buttonSeeMod.sprite = spriteOffSeeMod;
            }

            if(CountryId == 1)
            {   
               img[0].sprite = fieldCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 2)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = fieldCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 3)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = fieldCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 4)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = fieldCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 5)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = fieldCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 6)
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
        if (SeeFunction || AttackFunction)
        {
            return;
        }

            if (!ShowAllFlagCountry)
            {
               if(UkraineAttack)
               {
                   if (CountryId == 1)
                   {
                       img[0].sprite = SpriteUkraine[0];
                   }
                   else if (CountryId == 2)
                   {
                       img[0].sprite = SpriteMoldova[0]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[0].sprite = SpriteRumania[0]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[0].sprite = SpritePoland[0]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[0].sprite = SpriteSlovakia[0]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[0].sprite = SpriteHungary[0]; 
                   }
               }
               else
               {
                   img[0].sprite = fieldCountry[0];
               }

               if(MoldovaAttack)
               {
                   if (CountryId == 1)
                   {
                       img[1].sprite = SpriteUkraine[1];
                   }
                   else if (CountryId == 2)
                   {
                       img[1].sprite = SpriteMoldova[1]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[1].sprite = SpriteRumania[1]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[1].sprite = SpritePoland[1]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[1].sprite = SpriteSlovakia[1]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[1].sprite = SpriteHungary[1]; 
                   }
               }
               else
               {
                   img[1].sprite = fieldCountry[1];
               }

               if(RumaniaAttack)
               {
                   if (CountryId == 1)
                   {
                       img[2].sprite = SpriteUkraine[2];
                   }
                   else if (CountryId == 2)
                   {
                       img[2].sprite = SpriteMoldova[2]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[2].sprite = SpriteRumania[2]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[2].sprite = SpritePoland[2]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[2].sprite = SpriteSlovakia[2]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[2].sprite = SpriteHungary[2]; 
                   }
               }
               else
               {
                   img[2].sprite = fieldCountry[2];
               }

               if(PolandAttack)
               {
                   if (CountryId == 1)
                   {
                       img[3].sprite = SpriteUkraine[3];
                   }
                   else if (CountryId == 2)
                   {
                       img[3].sprite = SpriteMoldova[3]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[3].sprite = SpriteRumania[3]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[3].sprite = SpritePoland[3]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[3].sprite = SpriteSlovakia[3]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[3].sprite = SpriteHungary[3]; 
                   }
               }
               else
               {
                   img[3].sprite = fieldCountry[3];
               }

               if(SlovakiaAttack)
               {
                   if (CountryId == 1)
                   {
                       img[4].sprite = SpriteUkraine[4];
                   }
                   else if (CountryId == 2)
                   {
                       img[4].sprite = SpriteMoldova[4]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[4].sprite = SpriteRumania[4]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[4].sprite = SpritePoland[4]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[4].sprite = SpriteSlovakia[4]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[4].sprite = SpriteHungary[4]; 
                   }
               }
               else
               {
                   img[4].sprite = fieldCountry[4];
               }

               if(HungaryAttack)
               {
                   if (CountryId == 1)
                   {
                       img[5].sprite = SpriteUkraine[5];
                   }
                   else if (CountryId == 2)
                   {
                       img[5].sprite = SpriteMoldova[5]; 
                   }
                   else if (CountryId == 3)
                   {
                       img[5].sprite = SpriteRumania[5]; 
                   }
                   else if (CountryId == 4)
                   {
                       img[5].sprite = SpritePoland[5]; 
                   }
                   else if (CountryId == 5)
                   {
                       img[5].sprite = SpriteSlovakia[5]; 
                   }
                   else if (CountryId == 6)
                   {
                       img[5].sprite = SpriteHungary[5]; 
                   }
               }
               else
               {
                   img[5].sprite = fieldCountry[5];
               }

               ShowAllFlagCountry = true;
               buttonSeeAllCountry.sprite = spriteOffShowCountry;
            }
            else if (ShowAllFlagCountry)
            {
                if(CountryId == 1)
                {
                   img[0].sprite = fieldCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (CountryId == 2)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = fieldCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }

                else if (CountryId == 3)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = fieldCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (CountryId == 4)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = fieldCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (CountryId == 5)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = fieldCountry[4];
                   img[5].sprite = linearCountry[5];
                }
                else if (CountryId == 6)
                {
                   img[0].sprite = linearCountry[0];
                   img[1].sprite = linearCountry[1];
                   img[2].sprite = linearCountry[2]; 
                   img[3].sprite = linearCountry[3];
                   img[4].sprite = linearCountry[4];
                   img[5].sprite = fieldCountry[5];
                 }

                 ShowAllFlagCountry = false;
                 buttonSeeAllCountry.sprite = spriteOnShowCountry;
        }
    }

    public void OnPressAttackMod()
    {
        if (ShowAllFlagCountry || SeeFunction)
        {
            return;
        }

        AttackFunction = !AttackFunction;

        if (AttackFunction)
        {
            buttonAttack.sprite = spriteOnAttack;      
        }
        else if (!AttackFunction)
        {
            if(CountryId == 1)
            {   
               img[0].sprite = fieldCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 2)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = fieldCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 3)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = fieldCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 4)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = fieldCountry[3];
               img[4].sprite = linearCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 5)
            {
               img[0].sprite = linearCountry[0];
               img[1].sprite = linearCountry[1];
               img[2].sprite = linearCountry[2]; 
               img[3].sprite = linearCountry[3];
               img[4].sprite = fieldCountry[4];
               img[5].sprite = linearCountry[5];  
            }
            else if (CountryId == 6)
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
        if (AttackFunction && CountryId != 1 && !UkraineAttack)
        {
            img[0].sprite = fieldCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 1;
            PanelAttack.SetActive(true);
        }
        else if(UkraineAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 1)
        {
            if (!ActiveHelpMessage && CountryId == 1 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressMoldovaAttack()
    {
        if (AttackFunction && CountryId != 2 && !MoldovaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = fieldCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 2;
            PanelAttack.SetActive(true);
        }
        else if(MoldovaAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 2)
        {
            if (!ActiveHelpMessage && CountryId == 2 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressRumuniaAttack()
    {
        if (AttackFunction && CountryId != 3 && !RumaniaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = fieldCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 3;
            PanelAttack.SetActive(true);
        }
        else if(RumaniaAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 3)
        {
            if (!ActiveHelpMessage && CountryId == 3 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressPolandAttack()
    {
        if (AttackFunction && CountryId != 4 && !PolandAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = fieldCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 4;
            PanelAttack.SetActive(true);
        }
        else if(PolandAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 4)
        {
            if (!ActiveHelpMessage && CountryId == 4 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressSlovakiaAttack()
    {
        if (AttackFunction && CountryId != 5 && !SlovakiaAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = fieldCountry[4];
            img[5].sprite = linearCountry[5];

            attackModID = 5;
            PanelAttack.SetActive(true);
        }
        else if(SlovakiaAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 5)
        {
            if (!ActiveHelpMessage && CountryId == 5 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressHungaryAttack()
    {
        if (AttackFunction && CountryId != 6 && !HungaryAttack)
        {
            img[0].sprite = linearCountry[0];
            img[1].sprite = linearCountry[1];
            img[2].sprite = linearCountry[2];
            img[3].sprite = linearCountry[3];
            img[4].sprite = linearCountry[4];
            img[5].sprite = fieldCountry[5];

            attackModID = 6;
            PanelAttack.SetActive(true);
        }
        else if(HungaryAttack)
        {
            if (!ActiveHelpMessage && AttackFunction)
            {
                HelpMessageId = 2;
                StartCoroutine(MessageWarning());
            }
        }
        else if (CountryId == 6)
        {
            if (!ActiveHelpMessage && CountryId == 6 && AttackFunction)
            {
                HelpMessageId = 1;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressYesAttack()
    {
        if(curency <= 5500)
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 3;
                StartCoroutine(MessageWarning());
            }

            return;
        }

        if(!UkraineAttack)
        {
            OnAttack();
        }
        else if (!MoldovaAttack)
        {
            OnAttack();
        }
        else if (!RumaniaAttack)
        {
            OnAttack();
        }
        else if (!PolandAttack)
        {
            OnAttack();
        }
        else if (!SlovakiaAttack)
        {
            OnAttack();
        }
        else if (!HungaryAttack)
        {
            OnAttack();
        }
    }

    public void OnPressNoAttack()
    {
        PanelAttack.SetActive(false);
        AttackYes.interactable = true;

        ProcentAttack = 0;
        TextProcent.text = ProcentAttack.ToString() + "%";

        AttackData.text = "Status:None";
        AttackData.color = Color.white;

        IsAttack = false;
    }

    public void OnAttack()
    {
        StartCoroutine(AttackProcentWar());

        AttackYes.interactable = false;
        AttackNo.interactable = false;

        IsAttack = true;
    }
   
    private void Update()
    {
        if (curency <= 0)
        {
            curency = 0;
        }

        int.TryParse(CurensyIntField.text, out int IntMoney);
        int.TryParse(CurensyIntFieldErase.text, out int IntMoneyErase);

        IntCurensy = IntMoney;
        IntCurensyErase = IntMoneyErase;

        curencyText.text = curency.ToString();

        if (curency >= 1000000000000000000) {
            curencyText.text = (1f * curency / 1000000000000000000).ToString() + "QB";
        }
        else if (curency >= 1000000000000000) {
            curencyText.text = (1f * curency / 1000000000000000).ToString() + "Q";
        }
        else if (curency >= 1000000000000) {
            curencyText.text = (1f * curency / 1000000000000).ToString() + "T";
        }
        else if (curency >= 1000000000) {
            curencyText.text = (1f * curency / 1000000000).ToString() + "B";
        }
        else if (curency >= 1000000) {
            curencyText.text = (1f * curency / 1000000).ToString() + "M";
        }
        else if (curency >= 1000) {
            curencyText.text = (1f * curency / 1000).ToString() + "K";
        }
        else {
            curencyText.text = curency.ToString();
        }

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

    public void OnClikAttackDeveloper()
    {
        if(UkraineAttackFunction.isOn == true)
        {
            UkraineAttack = true;
        }
        else if (UkraineAttackFunction.isOn == false)
        {
            UkraineAttack = false;
        }

        if(MoldovaAttackFunction.isOn == true)
        {
            MoldovaAttack = true;
        }
        else if (MoldovaAttackFunction.isOn == false)
        {
            MoldovaAttack = false;
        }

        if(RumaniaAttackFunction.isOn == true)
        {
            RumaniaAttack = true;
        }
        else if (RumaniaAttackFunction.isOn == false)
        {
            RumaniaAttack = false;
        }

        if(PolandAttackFunction.isOn == true)
        {
            PolandAttack = true;
        }
        else if (PolandAttackFunction.isOn == false)
        {
            PolandAttack = false;
        }

        if(SlovakiaAttackFunction.isOn == true)
        {
            SlovakiaAttack = true;
        }
        else if (PolandAttackFunction.isOn == false)
        {
            SlovakiaAttack = false;
        }

        if(HungaryAttackFunction.isOn == true)
        {
            HungaryAttack = true;
        }
        else if (PolandAttackFunction.isOn == false)
        {
            HungaryAttack = false;
        }
    }

    public void OnOpenPanMenu()
    {
        if (PanelCountryInformation.activeSelf || PanelChat.activeSelf || PanelUpgrade.activeSelf || PanelTask.activeSelf || PanelDevoleperFunctions.activeSelf)
        {
            return;
        }

        PanelMenu.SetActive(!PanelMenu.activeSelf);
    }

    public void OnOpenPanUpgrade()
    {
        if (PanelCountryInformation.activeSelf || PanelChat.activeSelf || PanelMenu.activeSelf || PanelTask.activeSelf || PanelDevoleperFunctions.activeSelf)
        {
            return;
        }

        PanelUpgrade.SetActive(!PanelUpgrade.activeSelf);
    }

    public void OnOpenPanelTask()
    {
        if (PanelCountryInformation.activeSelf || PanelChat.activeSelf || PanelUpgrade.activeSelf || PanelMenu.activeSelf || PanelDevoleperFunctions.activeSelf)
        {
            return;
        }

        PanelTask.SetActive(!PanelTask.activeSelf);
        PanelDark.SetActive(!PanelDark.activeSelf);
    }

    public void OnOpenDeveloperMenu()
    {
        if (PanelCountryInformation.activeSelf || PanelUpgrade.activeSelf || PanelTask.activeSelf ||  PanelChat.activeSelf)
        {
            return;
        }

        PanelMenu.SetActive(!PanelMenu.activeSelf);
        PanelDevoleperFunctions.SetActive(!PanelDevoleperFunctions.activeSelf);
        PanelDark.SetActive(!PanelDark.activeSelf);
    }

    public void OnOpenChat()
    {
        if (PanelCountryInformation.activeSelf || PanelUpgrade.activeSelf || PanelMenu.activeSelf || PanelTask.activeSelf || PanelDevoleperFunctions.activeSelf)
        {
            return;
        }

        PanelChat.SetActive(!PanelChat.activeSelf);
        PanelChatLogin.SetActive(!PanelChatLogin.activeSelf);

        PanelDark.SetActive(!PanelDark.activeSelf);
    }

    public void OnOpenPanDataCountry()
    {
        if (PanelUpgrade.activeSelf || PanelChat.activeSelf || PanelDevoleperFunctions.activeSelf)
        {
            return;
        }

        if (PanelCountryInformation.activeSelf)
        {
            buttonDataCountry.sprite = spriteOnDataCountry;
        }
        else if (!PanelCountryInformation.activeSelf)
        {
            buttonDataCountry.sprite = spriteOffDataCountry;
        }

        PanelCountryInformation.SetActive(!PanelCountryInformation.activeSelf);
        PanelDark.SetActive(!PanelDark.activeSelf);
    }

    public void OnPressBackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnOpenPanChatInfo()
    {
        PanelChatInformation.SetActive(!PanelChatInformation.activeSelf);
    }

    public void OnPressBuyUpgradePopulation()
    {
        if (curency >= costUpgradeItem[0])
        {
            if (population.fillAmount >= 1f)
            {
                populationMedal.SetActive(true);
                return;
            }

            curency -= costUpgradeItem[0];
            costUpgradeItem[0] *= 2;

            population.fillAmount += populationFill;
        }
        else if (curency <= costUpgradeItem[0])
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 4;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressBuyUpgradeLivingZone()
    {
        if (curency >= costUpgradeItem[1])
        {
            if (livingZone.fillAmount >= 1f)
            {
                livingZoneMedal.SetActive(true);
                return;
            }

            curency -= costUpgradeItem[1];
            costUpgradeItem[1] *= 2;

            livingZone.fillAmount += livingZoneFill;
        }
        else if (curency <= costUpgradeItem[1])
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 4;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressBuyUpgradeIndustrialZone()
    {
        if (curency >= costUpgradeItem[2])
        {
            if (industrialZone.fillAmount >= 1f)
            {
                industrialZoneMedal.SetActive(true);
                return;
            }

            curency -= costUpgradeItem[2];
            costUpgradeItem[2] *= 2;

            industrialZone.fillAmount += industrialZoneFill;
        }
        else if (curency <= costUpgradeItem[2])
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 4;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressBuyUpgradeEntertainmentZone()
    {
        if (curency >= costUpgradeItem[3])
        {
            if (entertainmentZone.fillAmount >= 1f)
            {
                entertainmentZoneMedal.SetActive(true);
                return;
            }

            curency -= costUpgradeItem[3];
            costUpgradeItem[3] *= 2;

            entertainmentZone.fillAmount += entertainmentZoneFill;
        }
        else if (curency <= costUpgradeItem[3])
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 4;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnPressBuyUpgradeBuilderZone()
    {
        if (curency >= costUpgradeItem[4])
        {
            if (buildersZone.fillAmount >= 1f)
            {
                buildersZoneMedal.SetActive(true);
                return;
            }

            curency -= costUpgradeItem[4];
            costUpgradeItem[4] *= 2;

            buildersZone.fillAmount += buildersZoneFill;
        }
        else if (curency <= costUpgradeItem[4])
        {
            if (!ActiveHelpMessage)
            {
                HelpMessageId = 4;
                StartCoroutine(MessageWarning());
            }
        }
    }

    public void OnClikGetMoney()
    {
        curency += IntCurensy;
    }

    public void OnClikEraseMoney()
    {
        curency -= IntCurensyErase;
    }

    public void AttackWin()
    {
        if (attackModID == 1)
        {
            img[0].sprite = SpriteUkraine[0];
            UkraineAttack = true;
        }
        else if (attackModID == 2)
        {
            img[1].sprite = SpriteMoldova[1];
            MoldovaAttack = true;
        }
        else if (attackModID == 3)
        {
            img[2].sprite = SpriteRumania[2];
            RumaniaAttack = true;
        }
        else if (attackModID == 4)
        {
            img[3].sprite = SpritePoland[3];
            PolandAttack = true;
        }
        else if (attackModID == 5)
        {
            img[4].sprite = SpriteSlovakia[4];
            SlovakiaAttack = true;
        }
        else if (attackModID == 6)
        {
            img[5].sprite = SpriteHungary[5];
            HungaryAttack = true;
        }

        randMoney = Random.Range(1250, 14000);

        curency += randMoney;

        AttackData.text = "Status:Win";
        AttackData.color = Color.green;

        AttackYes.interactable = false;
        AttackNo.interactable = true;
    }

    public void AttackFail()
    {
        if (attackModID == 1)
        {          
            UkraineAttack = false;
        }
        else if (attackModID == 2)
        {
            MoldovaAttack = false;
        }
        else if (attackModID == 3)
        {          
            RumaniaAttack = false;
        }
        else if (attackModID == 4)
        {
            PolandAttack = false;
        }
        else if (attackModID == 5)
        {
            SlovakiaAttack = false;
        }
        else if (attackModID == 6)
        {
            HungaryAttack = false;
        }

        randMoney = Random.Range(1250, 25000);

        curency -= randMoney;

        AttackData.text = "Status:Fail";
        AttackData.color = Color.red;

        AttackYes.interactable = false;
        AttackNo.interactable = true;
    }

    IEnumerator MessageWarning()
    {
        ActiveHelpMessage = true;

        if(HelpMessageId == 1)
        {
            HelpMessageText.text = "This is your country!";
        }
        else if (HelpMessageId == 2)
        {
            HelpMessageText.text = "You have already conquered this country!";
        }
        else if (HelpMessageId == 3)
        {
            HelpMessageText.text = "You need more money for war!";
        }
        else if (HelpMessageId == 4)
        {
            HelpMessageText.text = "Not enough money!";
        }

        HelpMessage.SetActive(true);
        yield return new WaitForSeconds(1.8f);

        HelpMessage.SetActive(false);
        ActiveHelpMessage = false;
    
        HelpMessageText.text = "Sorry error !";
    }

    IEnumerator AttackProcentWar()
    {
        yield return new WaitForSeconds(SpeedAttack);

        ProcentAttack += 1;
        TextProcent.text = ProcentAttack.ToString() + "%";

        if (ProcentAttack <= 99)
        {
            StartCoroutine(AttackProcentWar());  

        }

        if(ProcentAttack >= 55)
        {
            SpeedAttack = 0.15f;
        }

        if(ProcentAttack == 100)
        {
            rand = Random.Range(1, 100);

            if(rand <= 35)
            {
                AttackWin();
                SpeedAttack = 0.25f;
            }
            else if (rand >= 35)
            {
                AttackFail();
                SpeedAttack = 0.25f;
            }          
        }
    }
}
