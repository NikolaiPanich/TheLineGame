using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public PlayerController player;

    //private void Start()
    //{
    //    player.currentHealth = player.maxHealth;
    //    Debug.Log(player.currentHealth);
    //}

    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currentHealth -= 5f;
        Debug.Log(player.currentHealth);
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}