using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sikaku : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Triangle")
        {
            Debug.Log("”»’è");
        }
    }
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.002f, 0);
    }
}
