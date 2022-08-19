using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCountryConttroler : GameConttroler
{
    private bool showCountryFlag;
    private bool seeMod;

    [Header("ButtonSeeAll")]
    public Image ButtonSeeAllCountry;

    public Sprite SpriteOnShowCountry;
    public Sprite SpriteOffShowCountry;

    [Header("ButtonSeeMod")]
    public Image ButtonSeeMod;

    public Sprite SpriteOnSeeMod;
    public Sprite SpriteOffSeeMod;

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
               ButtonSeeMod.sprite = SpriteOnSeeMod;
            }
            else if (!seeMod)
            {
               ButtonSeeMod.sprite = SpriteOffSeeMod;
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
               ButtonSeeAllCountry.sprite = SpriteOnShowCountry;
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
                ButtonSeeAllCountry.sprite = SpriteOffShowCountry;
            }
        }
    }
}
