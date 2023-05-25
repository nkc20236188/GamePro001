using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0Prefab;
    float span = 1.3f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ƒ‰ƒ“ƒ_ƒ€‚Å“G‚ð”z’u
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0Prefab);
            int y = Random.Range(4, -4);
            go.transform.position = new Vector3(10, y, 0);
        }
    }
}
