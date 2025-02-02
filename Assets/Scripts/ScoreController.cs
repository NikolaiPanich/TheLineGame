using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public PlayerController player;

    public Text scoreText;
    public int score = 0;

    void Start()
    {
        player.score = score;
    }

    void Update()
    {
        scoreText.text = "Score: " + player.score;
    }
}
