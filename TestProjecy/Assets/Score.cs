using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public 

    private void Update()
    {
        text.text = score.ToString();
    }
}
