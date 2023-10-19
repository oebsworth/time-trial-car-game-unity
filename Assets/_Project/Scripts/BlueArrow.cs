using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueArrow : MonoBehaviour
{
    [SerializeField] private GameObject blueFinishLine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
        blueFinishLine.SetActive(true);
    }
}
