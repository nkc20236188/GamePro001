using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShotGenerater : MonoBehaviour
{
    

    public GameObject MyShot_0Prehab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float f = Input.GetAxisRaw("Fire1");
        //spaseが押されたら球が出る
        if (f == 1)
        {
            GameObject go = Instantiate(MyShot_0Prehab);
        }
    }
}
