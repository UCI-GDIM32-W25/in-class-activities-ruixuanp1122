using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public W4Pigeon Player { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        Player = playerObj.GetComponent<W4Pigeon>();
    }
}
