using UnityEngine;

public class ResetPosition : MonoBehaviour
{

    private Vector3 startPos;
    private Rigidbody rB;

    private void Awake()
    {
        startPos = transform.position;
        rB = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rB.isKinematic = true;
            transform.position = startPos;
            transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
            rB.isKinematic = false;
        }
    }
}
