using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private ContactFilter2D _wall;
    //private Transform _level1Start, _level1_1, _level1_2, _level1_3, _level1_4;

    public PlayerController player;
    public float maxHealth = 100f;
    public float currentHealth = 100f;
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

        //_level1Start = GameObject.FindGameObjectWithTag("BackgroundStartLvl1").transform;
        //_level1_1 = GameObject.FindGameObjectWithTag("Background1Lvl1").transform;
        //_level1_2 = GameObject.FindGameObjectWithTag("Background2Lvl1").transform;
        //_level1_3 = GameObject.FindGameObjectWithTag("Background3Lvl1").transform;
        //_level1_4 = GameObject.FindGameObjectWithTag("Background4Lvl1").transform;
    }

    void Update()
    {
        if (currentHealth > 0)
        {
            MovePlayer();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void MovePlayer ()
    {
        //only move player if he is not in contact with wall
        //if (!IsContactWall)
        //{
        //    //for move player by X position
        //    _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //    _rigidbody.velocity *= playerSpeed;
        //}

        //for move player by X position
        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _rigidbody.velocity *= playerSpeed;

        //for move player by X and Y positions
        //Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //transform.Translate(speed * movement * Time.deltaTime);
    }

    //public void TakeDamage(float damage)
    //{
    //    currentHealth -= damage;
    //}

    //public void Heal(float heal)
    //{
    //    currentHealth += heal;
    //}

    //public void Die()
    //{
    //    currentHealth = 0;
    //}

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

    //    player.currentHealth -= 5f;
    //    Debug.Log(player.currentHealth);
    //    Destroy(gameObject);
    //    gameObject.SetActive(false);
    //}
}
