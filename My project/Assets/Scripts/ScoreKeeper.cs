using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper singleton;
    private int score = 0;
    public int State {get => score;set => score = value;}

    public void OnPickup(int coinPoints)
    {
        score += coinPoints;
        State = score;
    }

    public static ScoreKeeper Get()
    {
        if (singleton==null)
        {
            singleton = new ScoreKeeper();
        }
        return singleton;
    }
}
