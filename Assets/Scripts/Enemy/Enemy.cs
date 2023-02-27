using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private DestroyGameObject destroyGameObject;
     private GameObject parentObject;
    [SerializeField] private EnemyMovement enemyMovement;
    [SerializeField] private Animator animator;

    private void Start()
    {
        parentObject = transform.parent.gameObject;
    }
    private void Update()
    {
        if(hp <= 0)
        {
            destroyGameObject.DestroyThisObject();
            Destroy(parentObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerBullet"))
        {
            hp -= collision.GetComponent<PlayerBullet>().Dmg;
            animator.SetTrigger("hurt");
        }

        if (collision.CompareTag("PlayerArea"))
        {
            enemyMovement.CanMove = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerArea"))
        {
            enemyMovement.CanMove = false;
        }
    }

}
