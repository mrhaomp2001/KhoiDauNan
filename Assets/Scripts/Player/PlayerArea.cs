using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArea : MonoBehaviour
{
    [SerializeField] Transform transformPlayer;

    private void Update()
    {
        this.transform.position = transformPlayer.position;
    }
}
