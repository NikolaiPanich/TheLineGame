using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;
    public float speed = 10f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 0)
        {
            float moveLeft = Input.GetAxis("Horizontal");
            float moveRight = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveLeft, moveRight);
            transform.Translate(speed * movement * Time.deltaTime);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
        
        
}
