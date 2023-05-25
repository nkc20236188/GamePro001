using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyCharController : MonoBehaviour
{
    float speed = 0.05f;

    GameObject Player;
    GameObject wall_Left;
    GameObject wall_Right;
    GameObject wall_Bottom;
    GameObject wall_Top;

    Vector3 LeftPos;
    Vector3 RightPos;
    Vector3 BottomPos;
    Vector3 TopPos;

    void Start()
    {
        Player = GameObject.Find("MyChar_0");
        wall_Left = GameObject.Find("Wall_Left");
        wall_Right = GameObject.Find("Walll_Right");
        wall_Bottom = GameObject.Find("Wall_Bottom");
        wall_Top = GameObject.Find("Wall_Top");

        LeftPos = wall_Left.transform.position;
        RightPos = wall_Right.transform.position;
        BottomPos = wall_Bottom.transform.position;
        TopPos = wall_Top.transform.position;
    }

    void Update()
    {
        //xŽ²•ûŒü ˆÚ“®
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x * speed, 0 , 0);
        //yŽ²•ûŒü ˆÚ“®
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);

        Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, LeftPos.x, RightPos.x),
               Mathf.Clamp(Player.transform.position.y, BottomPos.y, TopPos.y)));
    }
}
