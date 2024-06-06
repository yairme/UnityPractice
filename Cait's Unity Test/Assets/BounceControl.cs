using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceControl : MonoBehaviour
{
    public GUIStyle style;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 400, Screen.height / 2 + 400, 800, 100));
        var shouldIncrease = GUI.Button(new Rect(0, 0, 300, 100), "Increase Speed", style);
        var shouldDecrease = GUI.Button(new Rect(500, 0, 300, 100), "Decrease Speed", style);
        GUI.EndGroup();
        if (shouldIncrease || shouldDecrease)
        {
            var vel = GetComponent<Velocity>();
            if (shouldIncrease)
            {
                vel.vel *= 1.5f;
            }
            else
            {
                vel.vel /= 1.5f;
            }
        }
    }
}
