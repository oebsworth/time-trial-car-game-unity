using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBarrel : MonoBehaviour
{
    [SerializeField] GameObject blueArrow;
    private int maxBlueBarrelCounter = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.currentBlueBarrelCount++;
        this.gameObject.SetActive(false);
        if (maxBlueBarrelCounter <= GameManager.Instance.currentBlueBarrelCount)
        {
            blueArrow.SetActive(true);
        }
    }
}
