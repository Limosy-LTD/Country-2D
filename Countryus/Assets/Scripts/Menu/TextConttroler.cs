using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextConttroler : MonoBehaviour
{
    [Header("Text Group")]
    [SerializeField] Text[] Text;

    [Header("Language")]

    public bool IsEnglishLanguage;
    public bool IsUkraineLanguage;

    public void Start()
    {
        SelectLanguageIsEnglish();
        IsEnglishLanguage = true;
    }

    public void Update()
    {
        if (IsEnglishLanguage)
        {
            SelectLanguageIsEnglish();
        }
        else if (IsUkraineLanguage)
        {
            SelectLanguageIsUkraine();
        }
    }

    public void SelectLanguageIsEnglish()
    {
        Text[0].text = "Start";

        //Country Names

        Text[1].text = "Ukraine";
        Text[2].text = "Moldova";
        Text[3].text = "Rumania";
        Text[4].text = "Poland";
        Text[5].text = "Slovakia";
        Text[6].text = "Hungary";
    }

    public void SelectLanguageIsUkraine()
    {
        Text[0].text = "Почати";

        //Country Names

        Text[1].text = "Україна";
        Text[2].text = "Молдова";
        Text[3].text = "Румунія";
        Text[4].text = "Польща";
        Text[5].text = "Словаччина";
        Text[6].text = "Угорщина";
    }
}
