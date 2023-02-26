using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    [SerializeField] private Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            player.Hp -= collision.GetComponent<EnemyBullet>().Dmg;
        }
    }


/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            player.Hp -= collision.gameObject.GetComponent<EnemyBullet>().Dmg;
        }
    }*/
}
