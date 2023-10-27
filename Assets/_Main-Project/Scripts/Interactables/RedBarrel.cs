using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBarrel : MonoBehaviour
{
    [Header("Arrows")]
    [SerializeField] GameObject redArrow;
    private int maxRedBarrelCounter = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<RedCar>() != null)
        {
            GameManager.Instance.currentRedBarrelCount++;

            this.gameObject.SetActive(false);

            if (maxRedBarrelCounter <= GameManager.Instance.currentRedBarrelCount)
            {
                redArrow.SetActive(true);
            }
        }
    }
}
