using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    private float _startTransformPositionLevelObjectsY;
    public GameObject levelObjects;
    public GameObject[] levelBlocks;
    [Range(0f, 1f)]
    public float mapSpeed = 0.01f;

    private void Awake()
    {
        _startTransformPositionLevelObjectsY = levelObjects.transform.position.y;
    }
    void Start()
    {
        SpawnLevelObjects();
    }

    void Update()
    {
        if (levelObjects != null)
        {
            Debug.Log("Moving Blocks");
            levelObjects.transform.position = new Vector3(0, levelObjects.transform.position.y - mapSpeed, 1);
        }
        //Restart();
    }

    //private void Restart()
    //{
    //    float levelDistance = -55f;
    //    if (levelObjects.transform.position.y < levelDistance)
    //    {
    //        levelObjects.transform.position = new Vector2(0, _startTransformPositionLevelObjectsY);
    //    }
    //}    

    private void SpawnLevelObjects()
    {
        for (int i = 0; i < levelBlocks.Length; i++)
        {
            float levelBlockY = levelBlocks[i].transform.position.y;
            float levelBlockX = levelBlocks[i].transform.position.x;
            var blocksClone = Instantiate(levelBlocks[i], new Vector3(levelBlockX, levelBlockY, 1), Quaternion.identity);
            blocksClone.transform.parent = transform;
        }
    }
}
