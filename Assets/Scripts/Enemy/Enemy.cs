using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int hp;
    [SerializeField] private DestroyGameObject destroyGameObject;
    [SerializeField] private GameObject parentObject;

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
        if(collision.tag == "PlayerBullet")
        {
            hp -= collision.GetComponent<PlayerBullet>().Dmg;
        }
    }

}
