using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 now = rb.position;
        now += new Vector2(-0.05f, 0);
        rb.position = now;

        //��ʂ����������I�u�W�F�N�g������
        if (transform.position.x < -9.5f)
        {
            Destroy(gameObject);
        }


        //GameObject director = GameObject.Find("GameDirextor");
        //director.GetComponent<GameDirector>().DecreaseTime();

        
    }
    //�H�H�H�H�H�H�H�H�H�H�H
    //�I�u�W�F�N�g���Ԃ������������
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "MyChar_0")
        {
            Destroy(gameObject);

            //�Ԃ�������^�C�g���V�[���ɖ߂�
            SceneManager.LoadScene("TitleScene");

        }

        if (c.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);


        }
    }
}
