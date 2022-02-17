using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectSetup : MonoBehaviour
{
    private void Awake()
    {
        if (!ReferenceEquals(ProjectSettings.Instance, null))
        {
            Debug.Log("Project Settings: <color=#3AE>Initialised</color>");
        }
    }
}
