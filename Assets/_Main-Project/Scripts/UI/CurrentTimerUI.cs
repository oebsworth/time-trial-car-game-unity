using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTimerUI : MonoBehaviour
{
    [Header("Timers")]
    [SerializeField] TextMeshProUGUI redTimer;
    [SerializeField] TextMeshProUGUI blueTimer;

    private void Update()
    {
        UpdateTimerText(redTimer, "Red", GameManager.Instance.currentRedTimer);
        UpdateTimerText(blueTimer, "Blue", GameManager.Instance.currentBlueTimer);
    }

    private void UpdateTimerText(TextMeshProUGUI timer, string name, float value)
    {
        timer.text = $"{name}: {value.ToString("#.##")}";
    }
}
