using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{   
    private static UIManager singleton;
    private string preamble = "Score: ";
    ScoreKeeper scoreKeeper;
    private string text;
    void Start()
    {
        scoreKeeper = ScoreKeeper.Get();
    }
    // Update is called once per frame
    void Update()
    {
        text = preamble + scoreKeeper.State.ToString();
    }
    public static UIManager Get()
    {
        if (singleton == null)
        {
            singleton = new UIManager();
        };
        return singleton;
    }
}
