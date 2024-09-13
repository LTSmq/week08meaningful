using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper singleton;
    private int score = 0;
    public int State {get => score;set => score = value;}

    void Start()
    {
        if (singleton==null)
        {
            singleton = this;
        }
    }

    public void OnPickup(int coinPoints)
    {
        score += coinPoints;
        State = score;
    }

    public static ScoreKeeper Get()
    {
        if (singleton==null)
        {
            singleton = FindObjectOfType<ScoreKeeper>();
        }
        return singleton;
    }
}
