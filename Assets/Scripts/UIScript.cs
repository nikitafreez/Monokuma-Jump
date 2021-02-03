using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public static UIScript instance;
    public float scoreMax = 0;
    public Text scoreText;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float scoreCurrent = Mathf.Round(MonokumaScript.instance.ballPos.position.y * 35);
        if (scoreMax < scoreCurrent)
        {
            scoreMax = scoreCurrent;
        }
        scoreText.text = scoreMax.ToString();
    }
}
