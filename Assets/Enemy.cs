using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private DestroyGameObject destroyGameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            hp -= collision.GetComponent<PlayerBullet>().Dmg;
        }
    }

    private void Update()
    {
        if (hp <= 0)
        {
            destroyGameObject.DestroyThisObject();
        }
    }
}
