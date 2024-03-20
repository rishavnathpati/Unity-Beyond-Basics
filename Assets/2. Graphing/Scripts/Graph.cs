using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] private Transform pointPrefab;

    private void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * (i / 5f - 1f);
            point.localScale = Vector3.one / 5f;
        }
    }
}