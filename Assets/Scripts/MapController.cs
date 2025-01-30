using UnityEngine;

public class MapController : MonoBehaviour
{
    private GameObject _wallLeft, _wallRight, _tinyLetLeft, _tinyLetRight, _mediumLet, _bigLet;

    private Transform _player, _level1Start, _level1, _level2;

    //public GameObject[] mapObjects;

    //public GameObject prefab;

    private void Awake()
    {
        //lvl_1 >> _tinyLet
        //for (int i = 1; i < 3; i++)
        //{
        //    _wallLeft = Instantiate(mapObjects[0], new Vector2(Random.Range(-4, -3), 16 * i), Quaternion.Euler(0, 0, 0));
        //    _wallLeft.tag = $"StartWallLeft{i}";
        //    _wallRight = Instantiate(mapObjects[1], new Vector2(Random.Range(4, 3), 16 * i), Quaternion.Euler(0, 0, 0));
        //    _wallRight.tag = $"StartWallRight{i}";
        //    _tinyLetLeft = Instantiate(mapObjects[2], new Vector2(Random.Range(-3, -1), 16 * i), Quaternion.Euler(0, 0, 0));
        //    _tinyLetLeft.tag = $"TinyLetLeft{i}";
        //    _tinyLetRight = Instantiate(mapObjects[2], new Vector2(Random.Range(3, 1), 16 * i), Quaternion.Euler(0, 0, 0));
        //    _tinyLetRight.tag = $"TinyLetRight{i}";
        //}

        //_wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), 14), Quaternion.Euler(0, 0, 0));
        //_wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), 14), Quaternion.Euler(0, 0, 0));

        //_wallLeft.transform.localScale = new Vector3(2, 12, 1);
        //_wallRight.transform.localScale = new Vector3(2, 12, 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _level1Start = GameObject.FindGameObjectWithTag("BackgroundStartLvl1").transform;
        _level1 = GameObject.FindGameObjectWithTag("Background1Lvl1").transform;
        _level2 = GameObject.FindGameObjectWithTag("Background2Lvl1").transform;

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
        //if (_player.position.y > 0.6529305 /*&& _player.position.y < 5128*/)
        //{
        //    Debug.LogWarning("Level 2");
        //    _level1Start.transform.position = new Vector2(-960, 6823);

        //}
        
    }
}


