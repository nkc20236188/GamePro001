using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerContoller : MonoBehaviour
{
    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;

    void Start()
    {

    }

    void Update()
    {
        if (roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }

        if (UIobj.fillAmount == 0){
            SceneManager.LoadScene("TitleScene");
        }
    }
}
