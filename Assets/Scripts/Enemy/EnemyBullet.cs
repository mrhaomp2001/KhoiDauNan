using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int dmg;
    [SerializeField] private float speed;
    [SerializeField] private DestroyGameObject destroyGameObject;
    [SerializeField] private Rigidbody2D rb;

    public int Dmg { get => dmg; set => dmg = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerHitbox")
        {
            destroyGameObject.DestroyThisObject();
        }
    }

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }
}
