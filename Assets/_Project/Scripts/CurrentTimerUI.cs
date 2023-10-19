using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTimerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI redTimer;
    [SerializeField] TextMeshProUGUI blueTimer;

    private void Update()
    {
        redTimer.text = GameManager.Instance.currentRedTimer.ToString("#.##");
        blueTimer.text = GameManager.Instance.currentBlueTimer.ToString("#.##");
    }
}
