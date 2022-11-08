using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.Transform.Translated (0, 0, Time.deltaTime);
    }
}
