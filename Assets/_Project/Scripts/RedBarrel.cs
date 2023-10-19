using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBarrel : MonoBehaviour
{
    [SerializeField] GameObject redArrow;
    private int maxRedBarrelCounter = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.currentRedBarrelCount++;
        this.gameObject.SetActive(false);
        if (maxRedBarrelCounter <= GameManager.Instance.currentRedBarrelCount)
        {
            redArrow.SetActive(true);
        }
    }
}
