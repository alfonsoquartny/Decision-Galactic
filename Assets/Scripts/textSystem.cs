#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using UnityEditor;
using TMPro;

public class textSystem : MonoBehaviour
{

    public string[] leftStrings;
    public string[] rightStrings;


    public bool tr;
    public bool eng;
    public bool jp;

    public string[] nicks;
    public string[] infos;

    public TMP_Text question;

    private string Wording;
    private int quesIndex;
    public int aktifQuesIndex;


    public Text leftText;
    public Text RightText;
    public Text nick;
    public Text info;

    public SpriteRenderer sr;
    public Sprite[] sprites;

  public  string[] linesTR;
    public string[] linesEn;
    public string[] linesJp;
    public Text subtitles;


    public bool Diyalog2;
    public Drag drag;
    public TMP_Text diyalog2Text;
    public string[] diyalog2Strings;

    public managment Managment;

    void Start()
    {
        gameObject.transform.name = "card";
        linesTR = System.IO.File.ReadAllLines(@"Assets/languageTRdecision.txt");
        linesEn = System.IO.File.ReadAllLines(@"Assets/languageENdecision.txt");
         linesJp = System.IO.File.ReadAllLines(@"Assets/languageJPdecision.txt");


        drag =gameObject.GetComponent<Drag>();

        Managment.cards.Add(aktifQuesIndex);


        
            quesIndex = Random.Range(0, linesEn.Length);
        
        
        


            Managment = GameObject.FindGameObjectWithTag("management").GetComponent<managment>();

    }

    // Update is called once per frame
    void Update()
    {
        aktifQuesIndex = quesIndex;
        /* SORU CEVAPLAMA DEMO
        if (drag.yollandiLeft==true)
          {
              diyalog2Text.text = diyalog2Strings[quesIndex]+".";
          }
        *///SORU CEVAPLAMA DEMO
        if (tr == true)
        {
            leftText.text = leftStrings[quesIndex];
            RightText.text = rightStrings[quesIndex];
            sr.sprite = sprites[quesIndex];

            nick.text = nicks[quesIndex];
            info.text = infos[quesIndex];

            question.text = linesTR[quesIndex];

            aktifQuesIndex = quesIndex;
        }

        if (eng == true)
        {
            leftText.text = leftStrings[quesIndex];
            RightText.text = rightStrings[quesIndex];
            sr.sprite = sprites[quesIndex];
            nick.text = nicks[quesIndex];
            info.text = infos[quesIndex];

            question.text = linesEn[quesIndex];
        }

        if (jp == true)
        {
            leftText.text = leftStrings[quesIndex];
            RightText.text = rightStrings[quesIndex];
            sr.sprite = sprites[quesIndex];
            nick.text = nicks[quesIndex];
            info.text = infos[quesIndex];

            question.text = linesJp[quesIndex];
        }
          
       


    }


}
#endif
