using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static ScoreKeeper singleton;
    private int score;
    public int State {get => score;set => score = value;}


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnPickup(int coinPoints)
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
