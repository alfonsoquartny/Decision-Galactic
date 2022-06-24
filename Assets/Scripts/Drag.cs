using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Drag : MonoBehaviour
{

    Vector2 difference = Vector2.zero;
    public float smoothRot;
    public float smoothPos;
    public float rotZ;
    public Text LeftText;
    public Text RightText;

    public GameObject prefab;

    public textSystem textSystem;
    private bool rightTaken;


   private Vector3 defaultPos = new Vector3(0f, -10.3f, 0);
    private Vector3 rightTakedPos = new Vector3(0, -17, 0);


    public bool isRight;
    public bool isLeft;
    public Color ZmRight;
    public Color ZmLeft;
    private bool mouseDown = false;

    private void Start()
    {
    }
    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    // Update is called once per frame
    void Update()
    {


        RightText.color = ZmRight;
        LeftText.color = ZmLeft;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        if (isRight == true)
        {
            rotZ -= Time.deltaTime * smoothRot;
            if (rotZ < -15)
            {
                rotZ = -15;
             
            }
            ZmRight.a += Time.deltaTime * 2f;


        }
        else
        {
            ZmRight.a -= Time.deltaTime * 5f;
        }

        if (ZmRight.a> 1)
        {
            ZmRight.a= 1;
        }

        if (ZmRight.a < 0)
        {
            ZmRight.a = 0;
        }

        if (isLeft==true)
        {
            rotZ += Time.deltaTime * smoothRot;
            if (rotZ > 15)
            {
                rotZ = 15;
            }
            ZmLeft.a += Time.deltaTime * 2f;
        }
        else
        {
            ZmLeft.a -= Time.deltaTime * 5f;
        }

        if (ZmLeft.a > 1)
        {
            ZmLeft.a = 1;
        }

        if (ZmLeft.a < 0)
        {
            ZmLeft.a = 0;
        }


        if (rightTaken == true)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, rightTakedPos, Time.deltaTime * smoothPos);
        }



        if (mouseDown == false&&rightTaken==false)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, defaultPos, Time.deltaTime *19);

            if (rotZ < 0)
            {
                rotZ += Time.deltaTime * 70;
            }

            if (rotZ > 0)
            {
                rotZ -= Time.deltaTime * 70;
            }
                

        }
       

    }

    private void FixedUpdate()
    {
      
    }
   


    private void OnMouseDrag()
    {
        mouseDown = true;
        if (rightTaken == false)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        }
     

    }

    private void OnMouseUp()
    {
        mouseDown = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            isRight = true;

          
        }
        if (collision.gameObject.CompareTag("left"))
        {
            isLeft = true;
        }



        if (collision.gameObject.CompareTag("rightTaked"))
        {
            rightTaken = true;
            Destroy(this.gameObject, 3f);
            Instantiate(prefab);

        }

        if (collision.gameObject.CompareTag("leftTaked"))
        {
           rightTaken = true;
            Destroy(this.gameObject, 3f);
            Instantiate(prefab);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("right"))
        {
            isRight = false;
        }

        if (collision.gameObject.CompareTag("left"))
        {
            isLeft = false;
        }


    }
}
