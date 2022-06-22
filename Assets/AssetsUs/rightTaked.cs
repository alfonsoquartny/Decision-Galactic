using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightTaked : MonoBehaviour
{
    public rightTaked righttaked;
    public int totalY�netim;

    private GameObject tarihObject;
    public Text tarihText;
    void Start()
    {

        tarihObject = GameObject.FindGameObjectWithTag("tarihText");
        tarihText = tarihObject.GetComponent<Text>();
        tarihObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        tarihText.text = righttaked.totalY�netim + " G�nd�r Taraflar Dengede..";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            righttaked.totalY�netim = righttaked.totalY�netim + 1;
        }
    }
}
