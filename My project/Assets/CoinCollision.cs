using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(collider Collider) {
        ScoreKeeper.Get().OnPickup(1);
    }
    

    void Update()
    {
        
    }
}
