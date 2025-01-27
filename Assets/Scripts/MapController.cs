using UnityEngine;
using Random = UnityEngine.Random;

public class MapController : MonoBehaviour
{
    private GameObject _wallLeft;
    private GameObject _wallRight;
    
    public GameObject prefab;

    private void Awake()
    {
        //for (int i = 0; i < 2; i++)
        //{
        //    _wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));
        //    _wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));
        //}

        for (int j = 2; j < 15; j++)
        {
            _wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), j), Quaternion.Euler(0, 0, 0));
            _wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), j), Quaternion.Euler(0, 0, 0));
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

        //for (int i = 0; i < 2; i++)
        //{
        //    //_wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));
        //    //_wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), Random.Range(2, 1)), Quaternion.Euler(0, 0, 0));

        //    //_wallLeft.transform.position = new Vector2(-3, 2);
        //    //_wallRight.transform.position = new Vector2(3, 2);

        //    _wallLeft.transform.position = new Vector2(Random.Range(-3, -1), i);
        //    _wallRight.transform.position = new Vector2(Random.Range(3, 1), i);
        //}

    }

}


