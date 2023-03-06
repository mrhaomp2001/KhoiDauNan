using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int dmg;
    [SerializeField] private float speed;
    [SerializeField] private DestroyGameObject destroyGameObject;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private bool isLookAtPlayerStart, isLookAtPlayerUpdate;
    private Transform transformPlayer = null;



    public int Dmg { get => dmg; set => dmg = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerHitbox")
        {
            destroyGameObject.DestroyThisObject();
        }
    }

    private void Start()
    {
        if (transformPlayer == null)
        {
            transformPlayer = FindObjectOfType<PlayerHitbox>().GetComponent<Transform>();
        }

        if (isLookAtPlayerStart)
        {
            BulletMove();
        }
        if (!isLookAtPlayerStart) rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        if (isLookAtPlayerUpdate)
        {
            BulletMove();
        }
    }
    public void BulletMove()
    {
        Vector2 moveDirection = (transformPlayer.position - transform.position).normalized * speed;
        rb.velocity = moveDirection;

        rb.rotation = -Mathf.Atan2((transformPlayer.position - transform.position).x, (transformPlayer.position - transform.position).y) * Mathf.Rad2Deg + 90f;
    }
}
