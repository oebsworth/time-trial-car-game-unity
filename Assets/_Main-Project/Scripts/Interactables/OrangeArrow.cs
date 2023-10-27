using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeArrow : MonoBehaviour
{
    [SerializeField] private GameObject orangeFinishLine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
        orangeFinishLine.SetActive(true);
    }
}
