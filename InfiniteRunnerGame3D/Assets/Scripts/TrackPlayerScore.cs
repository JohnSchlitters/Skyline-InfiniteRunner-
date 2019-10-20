using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class TrackPlayerScore : MonoBehaviour
{
    public float playerScore = 0f;
    public WorldMove getScoreMultiplier ;

    public Text uiPlayerScore;
    // Start is called before the first frame update
    void Start()
    {
        print("Initialize player score tracking");
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = (playerScore * getScoreMultiplier.speedModifier);
        uiPlayerScore.text = (playerScore.ToString());
    }
}
