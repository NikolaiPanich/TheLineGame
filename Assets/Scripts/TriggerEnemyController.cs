using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public PlayerController player;

    private void Start()
    {
        player.currentHealth = player.maxHealth;
        Debug.Log($"Player health: {player.currentHealth}");
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currentHealth -= 5f;
        Debug.Log(player.currentHealth);
        Destroy(gameObject);
        //gameObject.SetActive(false);
        DiePlayer();
    }

    void DiePlayer()
    {
        if (player.currentHealth == 0)
        {
            Debug.Log($"Current health: {player.currentHealth}");
            player.Die();
            //Destroy(gameObject);
        }
    }
}
