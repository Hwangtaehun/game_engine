using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Sprite[] sprites;
    public bool isClicked;

    public void BtnClick()
    {
        isClicked = !isClicked;

        if (isClicked)
        {
            GameObject.Find("soundBt").GetComponent<UnityEngine.UI.Image>().sprite = sprites[0];
            Time.timeScale = 0f;
        }
        else
        {
            GameObject.Find("soundBt").GetComponent<UnityEngine.UI.Image>().sprite = sprites[1];
            Time.timeScale = 1f;
        }
    }
}
