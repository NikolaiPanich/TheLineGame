using UnityEngine;

public class BlocksController : MonoBehaviour
{
    public GameObject lastBlock;
    public GameObject BlocksPrefab;

    private void OnBecameInvisible()
    {
        Debug.Log("Invisible");
        Destroy(BlocksPrefab, 5f);
        //BlocksPrefab.SetActive(false);
    }

    private void OnBecameVisible()
    {
        Debug.Log("Visible");
        //BlocksPrefab.SetActive(true);
    }
}
