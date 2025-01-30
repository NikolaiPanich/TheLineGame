using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private ContactFilter2D _wall;
    private bool _isContactWall => _rigidbody.IsTouching(_wall);

    public float maxHealth = 100f;
    public float currentHealth = 100f;
    public float speed = 10f;
   

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 0)
        {
            Move();
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void Move ()
    {
        //only move player if he is not in contact with wall
        if (_isContactWall == false)
        {
            //for move player by X position
            _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            _rigidbody.velocity *= speed;
        }
        
        //for move player by X and Y positions
        //Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //transform.Translate(speed * movement * Time.deltaTime);
    }

    //private void OnBecameVisible()
    //{
    //    Debug.Log("OnBecameVisible");
    //    _spawner.Spawn();


    //}

    //private void OnBecameInvisible()
    //{
    //    Debug.Log("OnBecameInvisible");
    //    Destroy(gameObject);
    //}
}
