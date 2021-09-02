using UnityEngine;

public class FindObjectTest : MonoBehaviour
{

    private GameObject target;

    [SerializeField]
    private Vector3 translate = new Vector3(.5f, 0f, 0f);
    [SerializeField]
    private Vector3 rotate = new Vector3(0f, 0f, 1f);
    [SerializeField]
    private Vector3 scale = new Vector3(1.5f, 1.5f, 1.5f);


    void Start()
    {
        target = GameObject.Find("Cube_Tester");
    }

    void Update()
    {
        target.transform.Translate(translate * Time.deltaTime);
        target.transform.Rotate(rotate);
        target.transform.localScale = scale;
    }
}
