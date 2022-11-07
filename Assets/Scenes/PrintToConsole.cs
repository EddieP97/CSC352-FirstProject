using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hey, I'm printing to the console.");
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(0,0.5f,0); 
    }
}
