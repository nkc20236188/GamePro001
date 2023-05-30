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

        //��ʂ����������I�u�W�F�N�g������
        if (transform.position.x > 15f)
        {
            Destroy(gameObject);
        }

        //�G�ɂ��������������
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "Enemy_0Prehab")
            {
                Destroy(gameObject);
            }
        }
    }
}
