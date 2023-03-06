using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] private string collisonTag;
    [SerializeField] private bool isEnter, isExit;
    [SerializeField] private UnityEvent unityEventEnter, unityEventExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isEnter)
        {
            if (collision.CompareTag(collisonTag))
            {
                unityEventEnter.Invoke();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isExit)
        {
            if (collision.CompareTag(collisonTag))
            {
                unityEventExit.Invoke();
            }
        }
    }
}
