using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private FixedJoystick fixedJoystick;
    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        transform.position = transformPlayer.position;

        if (fixedJoystick.Direction.x != 0)
        {
            if (fixedJoystick.Direction.y != 0)
            {
                rb.rotation = -Mathf.Atan2(fixedJoystick.Direction.x, fixedJoystick.Direction.y) * Mathf.Rad2Deg + 90;
            }
        }
    }
}
