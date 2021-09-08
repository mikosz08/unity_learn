using UnityEngine;

public class TriggerEx : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(" Enter: " + other.gameObject.name.ToUpper());
    }

    private void OnTriggerExit(Collider other)
    {
        print(" Exit: " + other.gameObject.name.ToUpper());
    }

    private void OnTriggerStay(Collider other)
    {
        print(" Stay: " + other.gameObject.name.ToUpper());
    }
}
