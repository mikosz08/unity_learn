using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDestroy : MonoBehaviour
{

    private int sec = 1;
    float time = 0.0f;

    PrintDestroyes printer;
    CountDestroyes counter;

    private void Awake()
    {
        printer = PrintDestroyes.instance;
        counter = CountDestroyes.instance;

    }

    void Update()
    {
        time += Time.deltaTime;

        if (time > sec)
        {
            time = 0.0f;
            RollRandomDestroy();
            printer.PrintDestroyed(counter.Destroyes.ToString());
        }
    }

    private void RollRandomDestroy()
    {
        var roll = Random.Range(0, 10);

        if (roll > 7)
        {
            Destroy(this.gameObject);
            counter.AddDestory();
        }

    }
}
