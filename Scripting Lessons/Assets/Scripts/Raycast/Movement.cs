using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float offset = 5.0f;

    void Update()
    {
        MoveByMouse();
    }

    public void MoveByMouse()
    {
        var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, offset);
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

}
