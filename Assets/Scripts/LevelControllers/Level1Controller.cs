using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    private Transform _level1Start, _level1_1, _level1_2, _level1_3, _level1_4;

    public GameObject prefab;

    [Range(0f, 1f)]
    public float mapSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        _level1Start = GameObject.FindGameObjectWithTag("BackgroundStartLvl1").transform;
        _level1_1 = GameObject.FindGameObjectWithTag("Background1Lvl1").transform;
        _level1_2 = GameObject.FindGameObjectWithTag("Background2Lvl1").transform;
        _level1_3 = GameObject.FindGameObjectWithTag("Background3Lvl1").transform;
        _level1_4 = GameObject.FindGameObjectWithTag("Background4Lvl1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (prefab != null)
        {
            Debug.Log("Moving");
            prefab.transform.position = new Vector2(0, prefab.transform.position.y - mapSpeed);
        }
    }

    private void OnBecameInvisible()
    {
        Debug.Log("OnBecameInVisible");
        //gameObject.SetActive(false);
        Destroy(prefab, 5f);
    }
}
