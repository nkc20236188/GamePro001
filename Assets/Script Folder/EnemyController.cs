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
        //移動
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 now = rb.position;
        now += new Vector2(-0.05f, 0);
        rb.position = now;

        //画面から消えたらオブジェクトを消す
        if (transform.position.x < -9.5f)
        {
            Destroy(gameObject);
        }


        //GameObject director = GameObject.Find("GameDirextor");
        //director.GetComponent<GameDirector>().DecreaseTime();

        
    }
    //？？？？？？？？？？？
    //オブジェクトがぶつかったら消える
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "MyChar_0")
        {
            Destroy(gameObject);

            //ぶつかったらタイトルシーンに戻る
            SceneManager.LoadScene("TitleScene");

        }

        if (c.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);


        }
    }
}
