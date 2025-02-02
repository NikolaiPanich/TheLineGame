using Unity.VisualScripting;
using UnityEngine;

public class RewardTrigger : MonoBehaviour
{
    public PlayerController player;

    private void Start()
    {
        player.score = 0f;
        Debug.Log($"Player score: {player.score}");
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        player.score += 5f;
        Debug.Log(player.score);
        Destroy(gameObject);
        //gameObject.SetActive(false);
    }
}