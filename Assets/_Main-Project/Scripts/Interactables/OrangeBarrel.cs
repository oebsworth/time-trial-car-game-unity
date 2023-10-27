using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBarrel : MonoBehaviour
{
    [Header("Arrows")]
    [SerializeField] GameObject orangeArrow;
    private int maxOrangeBarrelCounter = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<OrangeCar>() != null)
        {
            GameManager.Instance.currentOrangeBarrelCount++;

            this.gameObject.SetActive(false);

            if (maxOrangeBarrelCounter <= GameManager.Instance.currentOrangeBarrelCount)
            {
                orangeArrow.SetActive(true);
            }
        }
    }
}
