using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0.05f, 0);

        //画面から消えたらオブジェクトを消す
        if (transform.position.x > 15f)
        {
            Destroy(gameObject);
        }

        //敵にあたったら消える
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Enemy_0Prehab")
            {
                Destroy(gameObject);
            }
        }
    }
}
