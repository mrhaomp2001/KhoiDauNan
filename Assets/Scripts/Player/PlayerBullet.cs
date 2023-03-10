using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private int dmg;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private DestroyGameObject destroyGameObject;


    public int Dmg { get => dmg; set => dmg = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            destroyGameObject.DestroyThisObject();
        }
    }

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }
}
