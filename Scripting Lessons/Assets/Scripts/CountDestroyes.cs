
using UnityEngine;

public class CountDestroyes : MonoBehaviour
{

    private static int destroyes = 0;

    public static CountDestroyes instance;

    private void Awake()
    {
        instance = this;
    }

    public int Destroyes
    {
        get { return destroyes; }
        set { destroyes = value; }
    }

    public void AddDestory()
    {
        Destroyes++;
    }

    public void ClearDestory()
    {
        Destroyes = 0;
    }

}
