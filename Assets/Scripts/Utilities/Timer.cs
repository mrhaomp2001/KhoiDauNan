using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Timer : MonoBehaviour
{
    [SerializeField] private float runtime;
    [SerializeField] private bool isCompleted;
    [SerializeField] private float timeTotal;
    [SerializeField] private UnityEvent unityEvent;

    public bool IsCompleted { get => isCompleted; set => isCompleted = value; }

    private void Start()
    {
        setTime();
    }

    private void Update()
    {
        if (Time.time >= runtime)
        {
            if (!isCompleted)
            {
                isCompleted = true;
                unityEvent.Invoke();
            }
        }
    }

    public void setTime()
    {
        runtime = Time.time + timeTotal;
        isCompleted = false;
    }
    public void setTime(float time)
    {
        runtime = Time.time + time;
        isCompleted = false;
    }
}