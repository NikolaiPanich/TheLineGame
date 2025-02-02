using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public PlayerController player;

    public Text healthText;
    //public int health;

    void Start()
    {
        //player.currentHealth = health;
    }

    void Update()
    {
        healthText.text = "HP: " + player.currentHealth;
    }
}
