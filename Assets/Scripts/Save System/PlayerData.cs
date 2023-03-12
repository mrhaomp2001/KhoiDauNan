using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    private int lv;
    public PlayerData (PlayerController playerController)
    {
        lv = playerController.Lv;
    }

    public int Lv { get => lv; set => lv = value; }
}
