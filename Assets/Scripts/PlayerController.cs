using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private ContactFilter2D _wall;
    public PlayerController player;
    //public PlayerController playerController;
    public float maxHealth = 100f;
    public float currentHealth;
    public float score = 0f;
    [Range(1f, 20f)]
    public float playerSpeed = 10f;
    private bool IsContactWall => _rigidbody.IsTouching(_wall);

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth > 0)
        {
            MovePlayer();
        }
        else
        {
            Die();
        }
    }

    public void MovePlayer ()
    {
        float lastPlayerPositionXRight = 7f;
        float lastPlayerPositionXLeft = -3f;

        if (player.transform.position.x > lastPlayerPositionXRight)
        {
            player.transform.position = new Vector3(lastPlayerPositionXRight, player.transform.position.y, 1);
        }

        if (player.transform.position.x < lastPlayerPositionXLeft)
        {
            player.transform.position = new Vector3(lastPlayerPositionXLeft, player.transform.position.y, 1);
        }

        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _rigidbody.velocity *= playerSpeed;
    }

    public void Die()
    {
        if (currentHealth == 0)
        {
            Debug.Log("Player is dead");
            //Destroy(gameObject);
            //gameObject.activeInHierarchy = false;

        }
    }

    //void OnTriggerEnter2D(Collider2D obj)
    //{
    //    //for animation:)
    //    //for (int y = 0; y < 2; y++)
    //    //{
    //    //    for (int x = 0; x < 2; x++)
    //    //    {
    //    //        GameObject wallLeft = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    //        wallLeft.AddComponent<Rigidbody>();
    //    //        wallLeft.transform.position = new Vector2(x, y);
    //    //    }
    //    //}
    //}
}
