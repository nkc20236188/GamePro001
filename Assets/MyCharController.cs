using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyCharController : MonoBehaviour
{
    float speed = 0.02f;

    float LeftPosX = -8.25f;
    float RightPosX = 8.3f;
    float BottomPosY = -4.55f;
    float TopPosY = 4.6f;

    GameObject Player;

    void Start()
    {
        Player = GameObject.Find("MyChar_0");
    }

    void Update()
    {
        //xŽ²•ûŒü ˆÚ“®
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x * speed, 0 , 0);
        //yŽ²•ûŒü ˆÚ“®
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);

        Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, LeftPosX, RightPosX),
               Mathf.Clamp(Player.transform.position.y, BottomPosY, TopPosY)));
    }
}
