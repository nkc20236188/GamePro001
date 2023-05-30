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
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 now = rb.position;
        now += new Vector2(0.07f, 0);
        rb.position = now;

        //画面から消えたらオブジェクトを消す
        if (transform.position.x > 15f)
        {
            Destroy(gameObject);
        }

        //敵にあたったら消える
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "Enemy_0Prehab")
            {
                Destroy(gameObject);
            }
        }
    }
}
