using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalTransision : MonoBehaviour
{
    [SerializeField] private Text textTransition;
    [SerializeField] private float x, y;
    [SerializeField] private Animator animator;

    public string TextTransitionString { get => textTransition.text; set => textTransition.text = value; }
    public float X { get => x; set => x = value; }
    public float Y { get => y; set => y = value; }

    public void StartTeleport()
    {
        animator.SetTrigger("start");
    }

    public void Teleport()
    {
        Transform transformPlayer = FindObjectOfType<PlayerHitbox>().transform;
        transformPlayer.position = new Vector3(x, y);
    }
}
