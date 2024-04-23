using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private bool isPause;
    private bool isMute;
    private float time;
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject soundOn;
    [SerializeField] private GameObject soundOff;
    [SerializeField] AudioMixer masterMixer;
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider sfxSlider;


    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        isPause = false;
        isMute = false;
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

        if (isMute)
        {
            masterMixer.SetFloat("Master", -80);
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            masterMixer.SetFloat("Master", 0);
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }

    public void ControllerOption()
    {
        isPause = !isPause;
    }

    public void SoundOn()
    {
        isMute = false;
    }

    public void SoundOff()
    {
        isMute = true;
    }

    public void Mainlevel()
    {
        SceneManager.LoadScene("Start");
    }

    public void sliderBGMControl()
    {
        float sound = bgmSlider.value;

        if (sound == -40.0f)
        {
            masterMixer.SetFloat("BGM", -80);
        }
        else
        {
            masterMixer.SetFloat("BGM", sound);
        }
    }

    public void sliderSFXControl()
    {
        float sound = sfxSlider.value;

        if (sound == -40.0f)
        {
            masterMixer.SetFloat("SFX", -80);
        }
        else
        {
            masterMixer.SetFloat("SFX", sound);
        }
    }
}
