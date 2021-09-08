using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{

    [SerializeField]
    private TMP_Text textEnter, textExit, textStay;

    int enter, exit, stay;

    private void OnTriggerEnter(Collider other)
    {
        ++enter;
        textEnter.SetText("Enter: " + enter.ToString());
    }

    private void OnTriggerExit(Collider other)
    {
        ++exit;
        textExit.SetText("Exit: " + exit.ToString());
    }

    private void OnTriggerStay(Collider other)
    {
        ++stay;
        textStay.SetText("Stay: " + stay.ToString());
    }
}

