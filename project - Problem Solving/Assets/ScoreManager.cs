using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text TxtScore;

    private int ValueScore;
    // Start is called before the first frame update
    void Start()
    {
        ValueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        TxtScore.text = $"Score : { ValueScore.ToString("0") }";
    }

    public void AddScore(int value)
    {
        ValueScore += value;
    }
}
