using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyShotGenerater : MonoBehaviour
{
    public GameObject MyShot_0Prehab;

    bool One;

    // Start is called before the first frame update
    void Start()
    {
        One = true;
    }

    // Update is called once per frame
    void Update()
    {
        //spaseが押されたら球が出る
        //if (Input.GetButtonDown("Jump"))
        //{
        //    One = true;
        //}

        if (One)
        {
            GameObject go = Instantiate(MyShot_0Prehab);

            One = false;
        }
    }
}
