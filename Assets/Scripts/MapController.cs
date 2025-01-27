using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MapController : MonoBehaviour
{
    private GameObject _wallLeft;
    private GameObject _wallRight;
    
    public GameObject prefab;


    private void Awake()
    {
        for (int i = 0; i < 2; i++)
        {
            _wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));
            _wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //for animation:)
        //for (int y = 0; y < 2; y++)
        //{
        //    for (int x = 0; x < 2; x++)
        //    {
        //        GameObject wallLeft = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //        wallLeft.AddComponent<Rigidbody>();
        //        wallLeft.transform.position = new Vector2(x, y);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        _wallLeft.transform.position = new Vector2(-3, 2);
        _wallRight.transform.position = new Vector2(3, 2);
    }

    //void OnCollisionEnter(Collision otherObj)
    //{
    //    if (otherObj.gameObject.tag == "Missile")
    //    {
    //        Destroy(gameObject, .5f);
    //    }
    //}

}


