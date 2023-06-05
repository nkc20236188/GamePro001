using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyCharController : MonoBehaviour
{
    //Player�̑��x
    float speed = 0.02f;

    //�ړ��͈�
    float LeftPosX = -8.25f;
    float RightPosX = 8.3f;
    float BottomPosY = -4.55f;
    float TopPosY = 4.6f;

    //�A�j���[�^�[�R���|�[�l���g��ۑ�����ϐ�
    Animator anm;

    


    GameObject Player;

    public GameObject MyShot_0;

    void Start()
    {
        Player = GameObject.Find("MyChar_0");

        //�R���|�[�l���g���擾
        anm = GetComponent<Animator>();

        
    }

    void Update()
    {
        


        //x������ �ړ�
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x * speed, 0 , 0);
        //y������ �ړ�
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y * speed, 0);

        Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, LeftPosX, RightPosX),
               Mathf.Clamp(Player.transform.position.y, BottomPosY, TopPosY)));


        

        //�L�[���͂ɂ��A�j���[�V�����̕ύX
        if (y == 0)
        {
            anm.Play("MyChar_0");
        }
        else if (y == 1)
        {
            anm.Play("MyChar_0L");
        }
        else
        {
            anm.Play("MyChar_0R");
        }

        //�V���b�g
        if (Input.GetButtonDown("Jump"))
        {
            GameObject playerShot = Instantiate(MyShot_0, transform.position + transform.forward * 3 + transform.up * 1, transform.rotation) as GameObject;
            //playerShot.transform.position = this.transform.position;
        }
    }
}
