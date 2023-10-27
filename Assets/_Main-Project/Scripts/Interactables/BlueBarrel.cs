using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBarrel : MonoBehaviour
{
    [Header("Arrows")]
    [SerializeField] GameObject blueArrow;
    private int maxBlueBarrelCounter = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BlueCar>() != null)
        {
            GameManager.Instance.currentBlueBarrelCount++;

            this.gameObject.SetActive(false);

            if (maxBlueBarrelCounter <= GameManager.Instance.currentBlueBarrelCount)
            {
                blueArrow.SetActive(true);
            }
        }
    }
}
