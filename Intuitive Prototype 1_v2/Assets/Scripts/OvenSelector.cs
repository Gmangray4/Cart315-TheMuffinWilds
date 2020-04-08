using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenSelector : MonoBehaviour
{
    public int oven = 1;
    public float min, max;
    public int ovenMax;

    // Start is called before the first frame update

    void Start()
    {
        Invoke("InvokePlease", 0.5f);

    }



    void InvokePlease()
    {
        float ranDumbTime = Random.Range(min, max);
        oven = Random.Range(1, ovenMax);
        Invoke("InvokePlease", ranDumbTime);
        print("InvokeWoking");
        print(oven);
    }
}
