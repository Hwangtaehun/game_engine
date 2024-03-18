using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    private float time;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        int minute, second;

        time += Time.deltaTime;

        if (time >= 60)
        {
            minute = (int)(time / 60);
            second = (int)(time % 60);
            text.text = minute.ToString() + "∫–" + second.ToString() + "√ ";
        }
        else
        {
            second = (int)time;
            text.text = second.ToString() + "√ ";
        }
    }
}
