using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedArrow : MonoBehaviour
{
    [SerializeField] private GameObject redFinishLine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
        redFinishLine.SetActive(true);
    }
}
