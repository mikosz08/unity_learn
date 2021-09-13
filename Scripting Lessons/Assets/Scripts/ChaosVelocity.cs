using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosVelocity : MonoBehaviour
{
    [SerializeField]
    private float chaosSpeed = 50.0f;

    private void Start()
    {
        // GetComponent<Rigidbody>().AddForce(chaosSpeed, 0, chaosSpeed);
        GetComponent<Rigidbody>().velocity = new Vector3(chaosSpeed, 0, chaosSpeed);
    }

}
