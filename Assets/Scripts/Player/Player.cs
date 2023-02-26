using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header(" >> Player\'s Stats: ")]
    [SerializeField] private float hp;
    [SerializeField] private float speed;
    
    [Header(" >> Components: ")]
    [SerializeField] private Rigidbody2D rb;

    [Header(" >> UI: ")]
    [SerializeField] private FixedJoystick fixedJoystick;

    [Header(" >> Player bullet: ")]
    [SerializeField] private Transform transformFirePoint;
    [SerializeField] private GameObject pistonBullet;

    public float Hp { get => hp; set => hp = value; }
    public float Speed { get => speed; set => speed = value; }

    private void Update()
    {
        Die();
        Movement();
        if(Input.GetKeyDown(KeyCode.A))
        {
            shoot();
        }
    }

    private void Die()
    {
        if (hp <= 0)
        {
            print("hết hp");
            hp++;
        }
    }

    public void shoot()
    {
        Instantiate(pistonBullet, transformFirePoint.position, transformFirePoint.rotation);
    }

    private void Movement()
    {
        if (fixedJoystick.Horizontal >= 0.3)
        {
            //move right
            rb.velocity = new Vector2(speed * fixedJoystick.Horizontal, rb.velocity.y);
        }
        else if (fixedJoystick.Horizontal <= -0.3)
        {
            //move left
            rb.velocity = new Vector2(speed * fixedJoystick.Horizontal, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        if (fixedJoystick.Vertical >= 0.3)
        {
            //move up
            rb.velocity = new Vector2(rb.velocity.x, speed * fixedJoystick.Vertical);
        }
        else if (fixedJoystick.Vertical <= -0.3)
        {
            //move down
            rb.velocity = new Vector2(rb.velocity.x, speed * fixedJoystick.Vertical);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
    }
}
