using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private bool isSolved = false;

    public bool IsSolved
    {
        get { return isSolved; }
        set { isSolved = value; }
    }

    private void OnTriggerEnter(Collider other)
    {
        var collidedObject = other.gameObject;

        if (collidedObject.CompareTag(this.tag))
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedObject);
        }

    }
}
