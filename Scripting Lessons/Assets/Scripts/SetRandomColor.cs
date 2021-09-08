using UnityEngine;

public class SetRandomColor : MonoBehaviour
{
    private void Awake()
    {
        ChangeMatColor();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeMatColor();
        }
    }

    public void ChangeMatColor()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}


