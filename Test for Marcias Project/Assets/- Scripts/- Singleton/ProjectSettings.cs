using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectSettings
{
    private static ProjectSettings _instance;
    public static ProjectSettings Instance
    {
        get
        {
            if (ReferenceEquals(_instance, null))
            {
                _instance = new ProjectSettings();
                _instance.Instantiate();
            }
            
            return _instance;
        }
    }

    private void Instantiate()
    {
        for (int i = 1; i < Math.Min(Display.displays.Length, 2); i++)
        {
            Display.displays[i].Activate();
        }
    }
}
