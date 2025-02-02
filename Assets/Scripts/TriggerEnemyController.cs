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
        if (obj.tag == "Reward1")
        {
            player.currentHealth += 5f;
            Debug.Log(player.currentHealth);
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
        else
        {
            player.currentHealth -= 5f;
            Debug.Log(player.currentHealth);
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
