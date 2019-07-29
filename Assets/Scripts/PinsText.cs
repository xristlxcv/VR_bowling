using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinsText : MonoBehaviour
{

    public Text life;
     Pins a;
    // Start is called before the first frame update
    void Update()
    {
        a = GameObject.Find("pins").GetComponent<Pins>();
        if (a)
        {
            life.text = a.numPins.ToString("0");
        }
    }
}
