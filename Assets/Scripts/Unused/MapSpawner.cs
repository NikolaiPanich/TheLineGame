using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnObjects;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _verticalOffset = 0.5f;

    private float? _lastYPosition = null;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
      
    }

    public void Spawn()
    {
        Transform randomSpawnPoint = _spawnObjects[Random.Range(0, _spawnObjects.Length)];
        float spawnPointsYPosition = _lastYPosition == null ? randomSpawnPoint.position.y : (float) _lastYPosition + _verticalOffset;

        randomSpawnPoint.position = new Vector2(randomSpawnPoint.position.x, spawnPointsYPosition);
        _lastYPosition = spawnPointsYPosition;
        Instantiate(_prefab, randomSpawnPoint.position, Quaternion.Euler(0, 0, 90));
        //_lastYPosition = randomSpawnPoint.position.y;
    }
}
