using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().playSound("coin");
        ScoringSystem.theScore += 10;
        Destroy(gameObject);
    }
}
