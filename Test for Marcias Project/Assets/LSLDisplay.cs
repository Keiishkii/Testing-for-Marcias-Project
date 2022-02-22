using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LSLDisplay : MonoBehaviour
{
    private LSLInput _lslInput;
    
    [SerializeField] private TMP_Text _lslSampleCountLabel;
    [SerializeField] private TMP_Text _lslInputLabel;
    
    
    
    private void Awake()
    {
        _lslInput = GetComponent<LSLInput>();
    }

    private void Update()
    {
        float[] sample = _lslInput.GetCurrentSample();

        if (sample != null)
        {
            int sampleCount = sample.Length;
            if (sampleCount > 0)
            {
                _lslSampleCountLabel.text = $"LSL Sample Count: {sampleCount}";
                _lslInputLabel.text = $"LSL Input: {sample[0]}";
            }
            else
            {
                _lslSampleCountLabel.text = $"LSL Sample Count: <color=#A00>0</color>";
                _lslInputLabel.text = $"LSL Input: {'{'}<color=#A00>No Stream</color>{'}'}";
            }
        }
    }
}
