using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Instantiate(prefab);
        }
        else if (Input.GetKey(KeyCode.B))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
