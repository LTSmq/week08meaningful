using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{   
    private static UIManager singleton;
    private TMP_Text textBox;
    private string preamble = "Score: ";
    ScoreKeeper scoreKeeper;
    private string text;
    void Start()
    {
        scoreKeeper = ScoreKeeper.Get();
        textBox = FindObjectOfType<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        text = preamble + scoreKeeper.State.ToString();
        textBox.text = text;
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
