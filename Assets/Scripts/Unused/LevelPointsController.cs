using UnityEngine;

public class LevelContrloller : MonoBehaviour
{
    private Transform _level1Start, _level1_1, _level1_2, _level1_3, _level1_4;

    void Start()
    {
        _level1Start = GameObject.FindGameObjectWithTag("BackgroundStartLvl1").transform;
        _level1_1 = GameObject.FindGameObjectWithTag("Background1Lvl1").transform;
        _level1_2 = GameObject.FindGameObjectWithTag("Background2Lvl1").transform;
        _level1_3 = GameObject.FindGameObjectWithTag("Background3Lvl1").transform;
        _level1_4 = GameObject.FindGameObjectWithTag("Background4Lvl1").transform;
    }

    private void OnBecameInvisible()
    {
        Debug.Log("Invisible");
        //Destroy(gameObject);
        //_level1Start.transform.position = new Vector2(-0.19147485f, 6.82f);
    }

    private void OnBecameVisible() 
    {
        Debug.Log("Visible");
        _level1_1.transform.position = new Vector2(0, _level1_1.position.y + _level1_4.position.y);
    }
}
