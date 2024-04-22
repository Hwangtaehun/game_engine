using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    private bool isPause;
    private float time;
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        isPause = false;
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

        if (isPause)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            panel.SetActive(false);
        }
    }

    public void ControllerOption()
    {
        isPause = !isPause;
    }
}
