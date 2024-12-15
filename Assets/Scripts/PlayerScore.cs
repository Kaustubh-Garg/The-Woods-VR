using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI scoretext;

    // Update is called once per frame
    public void IncrementScore()
    {
        score += 10;
        scoretext.text = "Score: " + score.ToString();
    }
}
