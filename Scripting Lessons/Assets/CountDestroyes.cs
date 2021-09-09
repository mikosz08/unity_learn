
using UnityEngine;

public class CountDestroyes : MonoBehaviour
{

    private int destroyes = 0;

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

    public int AddDestory()
    {
        Destroyes++;
        return Destroyes;
    }

    public void ClearDestoryes()
    {
        Destroyes = 0;
    }

}
