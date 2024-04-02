using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score;
    private int count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        
    }

    public void IncScore()
    {
        count += 1;
        this.score.text = count.ToString();
    }
}
