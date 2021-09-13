using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PrintDestroyes : MonoBehaviour
{
    [SerializeField]
    private TMP_Text destroyesCounterText;

    public static PrintDestroyes instance;

    private void Awake()
    {
        instance = this;
    }

    public void PrintDestroyed(string countText)
    {
        destroyesCounterText.SetText(countText.ToString()); ;
    }
}
