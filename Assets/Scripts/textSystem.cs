using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textSystem : MonoBehaviour
{

    public string[] questionText;
    public string[] leftStrings;
    public string[] rightStrings;
    public string[] nicks;
    public string[] infos;
    public Text question;
    private string Wording;
    private int quesIndex;

    public Text leftText;
    public Text RightText;
    public Text nick;
    public Text info;

    public SpriteRenderer sr;
    public Sprite[] sprites;
    void Start()
    {
        quesIndex = Random.Range(0, questionText.Length);
       Wording = questionText[quesIndex];

       
    }

    // Update is called once per frame
    void Update()
    {
       
            leftText.text = leftStrings[quesIndex];
            RightText.text = rightStrings[quesIndex];
            sr.sprite = sprites[quesIndex];
            nick.text = nicks[quesIndex];
            info.text = infos[quesIndex];
   

        question.text =""+Wording;
    }


}
