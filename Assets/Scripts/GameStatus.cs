using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    //Config Prams
    [SerializeField] int pointsPerBlockDestroyed = 83;

    //State
    [SerializeField] int currentScore = 0;
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void addToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
