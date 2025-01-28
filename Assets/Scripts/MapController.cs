using UnityEngine;
using Random = UnityEngine.Random;

public class MapController : MonoBehaviour
{
    private GameObject _wallLeft, _wallRight, _tinyLetLeft, _tinyLetRight, _mediumLet, _bigLet;

    private Transform _player, _startWallLeft, _startWallRight, _startWallLeft1, _startWallRight1, _startWallLeft2, _startWallRight2, _tinyLetLeft1, _tinyLetRight1, _tinyLetLeft2, _tinyLetRight2;

    public GameObject[] mapObjects;

    //public GameObject prefab;

    private void Awake()
    {
        //lvl_1 >> _tinyLet
        for (int i = 1; i < 3; i++)
        {
            _wallLeft = Instantiate(mapObjects[0], new Vector2(Random.Range(-4, -3), 16 * i), Quaternion.Euler(0, 0, 0));
            _wallLeft.tag = $"StartWallLeft{i}";
            _wallRight = Instantiate(mapObjects[1], new Vector2(Random.Range(4, 3), 16 * i), Quaternion.Euler(0, 0, 0));
            _wallRight.tag = $"StartWallRight{i}";
            _tinyLetLeft = Instantiate(mapObjects[2], new Vector2(Random.Range(-3, -1), 16 * i), Quaternion.Euler(0, 0, 0));
            _tinyLetLeft.tag = $"TinyLetLeft{i}";
            _tinyLetRight = Instantiate(mapObjects[2], new Vector2(Random.Range(3, 1), 16 * i), Quaternion.Euler(0, 0, 0));
            _tinyLetRight.tag = $"TinyLetRight{i}";
        }
        
        //_wallLeft = Instantiate(prefab, new Vector2(Random.Range(-3, -1), 14), Quaternion.Euler(0, 0, 0));
        //_wallRight = Instantiate(prefab, new Vector2(Random.Range(3, 1), 14), Quaternion.Euler(0, 0, 0));

        //_wallLeft.transform.localScale = new Vector3(2, 12, 1);
        //_wallRight.transform.localScale = new Vector3(2, 12, 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _startWallLeft = GameObject.FindGameObjectWithTag("StartWallLeft").transform;
        _startWallRight = GameObject.FindGameObjectWithTag("StartWallRight").transform;
        _startWallLeft1 = GameObject.FindGameObjectWithTag("StartWallLeft1").transform;
        _startWallRight1 = GameObject.FindGameObjectWithTag("StartWallRight1").transform;
        _startWallLeft2 = GameObject.FindGameObjectWithTag("StartWallLeft2").transform;
        _startWallRight2 = GameObject.FindGameObjectWithTag("StartWallRight2").transform;
        _tinyLetLeft1 = GameObject.FindGameObjectWithTag("TinyLetLeft1").transform;
        _tinyLetRight1 = GameObject.FindGameObjectWithTag("TinyLetRight1").transform;
        _tinyLetLeft2 = GameObject.FindGameObjectWithTag("TinyLetLeft2").transform;
        _tinyLetRight2 = GameObject.FindGameObjectWithTag("TinyLetRight2").transform;

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
        if (_player.position.y > 26 && _player.position.y < 26.1f)
        {
            _startWallLeft.transform.position = new Vector2(Random.Range(-4, -3), 16 * 3);
            _startWallRight.transform.position = new Vector2(Random.Range(4, 3), 16 * 3);
            _tinyLetLeft1.transform.position = new Vector2(Random.Range(-3, -1), 16 * 3);
            _tinyLetRight1.transform.position = new Vector2(Random.Range(3, 1), 16 * 3);
        }

        if (_player.position.y > 44 && _player.position.y < 44.1f)
        {
            _startWallLeft1.transform.position = new Vector2(Random.Range(-4, -3), 16 * 4);
            _startWallRight1.transform.position = new Vector2(Random.Range(4, 3), 16 * 4);
            _tinyLetLeft2.transform.position = new Vector2(Random.Range(-3, -1), 16 * 4);
            _tinyLetRight2.transform.position = new Vector2(Random.Range(3, 1), 16 * 4);
        }

        if (_player.position.y > 62 && _player.position.y < 62.1f)
        {
            _startWallLeft2.transform.position = new Vector2(Random.Range(-4, -3), 16 * 5);
            _startWallRight2.transform.position = new Vector2(Random.Range(4, 3), 16 * 5);
            _tinyLetLeft1.transform.position = new Vector2(Random.Range(-3, -1), 16 * 5);
            _tinyLetRight1.transform.position = new Vector2(Random.Range(3, 1), 16 * 5);
        }

        //int yPosition = 7;

        //if (_player.position.y > yPosition && _player.position.y < yPosition + 0.1f)
        //{
        //    Instantiate(mapObjects[0], new Vector2(-3, 26), Quaternion.Euler(0, 0, 0));
        //    Instantiate(mapObjects[1], new Vector2(3, 26), Quaternion.Euler(0, 0, 0));
        //}

        //if (_player.position.y > yPosition * 2)
        //{
        //    _startWallLeft.transform.position = new Vector2(-3, 38);
        //    _startWallRight.transform.position = new Vector2(3, 38);
        //}

        //if (_player.position.y > yPosition * 4 && _player.position.y < yPosition * 4 + 0.1f)
        //{
        //    Instantiate(mapObjects[0], new Vector2(-3, 50), Quaternion.Euler(0, 0, 0));
        //    Instantiate(mapObjects[1], new Vector2(3, 50), Quaternion.Euler(0, 0, 0));
        //}
    }
}


