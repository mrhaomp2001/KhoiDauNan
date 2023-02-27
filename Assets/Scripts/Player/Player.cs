using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header(" >> Player\'s Stats: ")]
    [SerializeField] private float hp;
    [SerializeField] private float speed;

    [Header(" >> Components: ")]

    [Header(" >> Player Hitbox: ")]
    [SerializeField] private Animator animPlayerHitbox;
    [SerializeField] private Rigidbody2D rbPlayerHitbox;
    [SerializeField] private Transform transformPlayerHitbox;


    [Header(" >> UI: ")]
    [SerializeField] private FixedJoystick fixedJoystick;

    [Header(" >> Player bullet: ")]
    [SerializeField] private Timer timerShootRate;
    [SerializeField] private Transform transformFirePoint;
    [SerializeField] private GameObject pistonBullet;

    public float Hp { get => hp; set => hp = value; }
    public float Speed { get => speed; set => speed = value; }
    public Animator AnimPlayerHitbox { get => animPlayerHitbox; set => animPlayerHitbox = value; }

    private void Update()
    {
        Die();
        Movement();
        PlayerAnimation();
        if (Input.GetKeyDown(KeyCode.A))
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
        if (timerShootRate.IsCompleted)
        {
            Instantiate(pistonBullet, transformFirePoint.position, transformFirePoint.rotation);
            timerShootRate.setTime();
        }
    }

    private void Movement()
    {
        if (fixedJoystick.Horizontal >= 0.3)
        {
            //move right
            rbPlayerHitbox.velocity = new Vector2(speed * fixedJoystick.Horizontal, rbPlayerHitbox.velocity.y);
            transformPlayerHitbox.localScale = new Vector3(1f, 1f);

        }
        else if (fixedJoystick.Horizontal <= -0.3)
        {
            //move left
            rbPlayerHitbox.velocity = new Vector2(speed * fixedJoystick.Horizontal, rbPlayerHitbox.velocity.y);
            transformPlayerHitbox.localScale = new Vector3(-1f, 1f);
        }
        else
        {
            rbPlayerHitbox.velocity = new Vector2(0f, rbPlayerHitbox.velocity.y);
        }

        if (fixedJoystick.Vertical >= 0.3)
        {
            //move up
            rbPlayerHitbox.velocity = new Vector2(rbPlayerHitbox.velocity.x, speed * fixedJoystick.Vertical);
        }
        else if (fixedJoystick.Vertical <= -0.3)
        {
            //move down
            rbPlayerHitbox.velocity = new Vector2(rbPlayerHitbox.velocity.x, speed * fixedJoystick.Vertical);
        }
        else
        {
            rbPlayerHitbox.velocity = new Vector2(rbPlayerHitbox.velocity.x, 0f);
        }
    }

    private void PlayerAnimation()
    {
        if (fixedJoystick.Direction.x != 0 || fixedJoystick.Direction.y != 0)
        {
            animPlayerHitbox.SetInteger("state", 1);
            return;
        }
        animPlayerHitbox.SetInteger("state", 0);

    }
}
