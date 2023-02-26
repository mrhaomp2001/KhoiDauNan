using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private bool destroyByTime;
    [SerializeField] private GameObject destroyEffect;

    public Timer Timer { get => timer; set => timer = value; }

    private void Update()
    {
        DestroyThisObjectByTime();
    }

    private void DestroyThisObjectByTime()
    {
        if (timer != null )
        {
            if (destroyByTime)
            {
                if (timer.IsCompleted)
                {
                    DestroyThisObject();
                }
            }
        }
    }

    public void DestroyThisObject()
    {
        Destroy(this.gameObject);

        if (destroyEffect != null)
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);
        }
    }
}
