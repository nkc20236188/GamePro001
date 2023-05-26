using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Time_gauge;

    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");
    }

    //0.1 タイマーが減っていく
    public void DecreaseTime()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        
    }
}
