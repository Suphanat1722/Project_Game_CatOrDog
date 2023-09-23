using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
       

    void Start()
    {
        Create_ArrowBox();
        Debug.Log("_____________________________________________________________");
    }

    
    void Update()
    {
        System_Press_ButtomArrow();
        
    }

    //________________________ระบบกำหนดปุ่มที่กด_________________________
    int roll = 0;
    int buttonPressed = 0;
    bool isPressing = false;
    void System_Press_ButtomArrow()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            buttonPressed = 1;
            isPressing = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            buttonPressed = 2;
            isPressing = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            buttonPressed = 3;
            isPressing = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            buttonPressed = 4;
            isPressing = true;
        }
        else
        {
            buttonPressed = 0;
            isPressing = false;
        }

        //เช็คว่า กดลูกศรตรงกับหน้าจอไหม
        if (isPressing && roll != Number_ButtonBox)
        {
            if (randomNum[roll] == buttonPressed)
            {
                Debug.Log("Roll " + (roll + 1) + " ____________Great!!!");
            }
            else if (randomNum[roll] != buttonPressed)
            {
                Debug.Log("Roll " + (roll + 1) + " ____________Fail!!!");
            }

            roll++;
        }
    }

    //________________________ระบบสร้างปุ่มหน้าเกมที่ให้เรากดตาม______________
    private int Number_ButtonBox = 4;
    private List<int> randomNum = new List<int>();
    private string[] arrowNames = { "Up", "Down", "Left", "Right" }; // สร้าง Array เพื่อเก็บชื่อของตัวเลข
    void Create_ArrowBox()
    {
        // สุ่มเลขว่าแต่ละช่องได้เลขอะไร
        for (int i = 0; i < Number_ButtonBox; i++)
        {
            int randomNumber = Random.Range(1, Number_ButtonBox + 1);
            randomNum.Add(randomNumber); // เพิ่มเลขสุ่มลงใน List
        }

        //Debug ดูเลข
        foreach (int arrow in randomNum)
        {
            // ใช้ Array เพื่อแปลงตัวเลขเป็นชื่อของตัวเลขและแสดงผล
            string debug_NumberToString = arrowNames[arrow - 1]; // ลบ 1 เนื่องจากตัวเลขเริ่มจาก 1 แต่ Array เริ่มจาก 0
            Debug.Log("Random Number = " + arrow + " " + debug_NumberToString);
        }
    }
}
