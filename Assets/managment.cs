using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managment : MonoBehaviour
{

    public List<int> cards=new List<int>();
    void Start()
    {
        PlayerPrefs.DeleteAll();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
