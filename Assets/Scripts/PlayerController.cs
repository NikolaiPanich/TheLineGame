using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveLeft = Input.GetAxis("Horizontal");
        float moveRight = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveLeft, moveRight);
        transform.Translate(_speed * movement * Time.deltaTime);
    }
}
