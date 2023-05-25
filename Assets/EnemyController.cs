using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //？？？？？？？？？？？
    //オブジェクトがぶつかったら消える
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.name == "MyChar_0")
        {
            //ぶつかったらタイマーが減る
            GameObject director = GameObject.Find("GameDirextor");
            director.GetComponent<GameDirector>().DecreaseTime();

            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.05f, 0, 0);

        //画面から消えたらオブジェクトを消す
        if (transform.position.x < -9.5f)
        {
            Destroy(gameObject);
        }

        
        //GameObject director = GameObject.Find("GameDirextor");
        //director.GetComponent<GameDirector>().DecreaseTime();
    }
}
