using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform upLeftCap, downRightCap;
    [SerializeField] private Rigidbody2D rbEnemy;
    [SerializeField] private Transform transformEnemy;
    [SerializeField] private float speed;

    [Header(" >> Move 2: ")]
    [SerializeField] private bool isMoveRight;
    [SerializeField] private bool isMoveUp;

    private void Start()
    {
    }

    private void Update()
    {
        Move2();

    }

    private void move()
    {
        float isMinus = Random.Range(-5, 5);
        // ben phai bi day nguoc lai
        if (transformEnemy.position.x > downRightCap.position.x)
        {

            rbEnemy.velocity = new Vector2(-speed, speed * isMinus);
        }
        // ben trai bi day nguoc lai
        if (transformEnemy.position.x < upLeftCap.position.x)
        {

            rbEnemy.velocity = new Vector2(speed, speed * isMinus);
        }
        // ben duoi bi day nguoc lai

        if (transformEnemy.position.y < downRightCap.position.y)
        {
            rbEnemy.velocity = new Vector2(speed * isMinus, speed);
        }
        // ben tren bi day nguoc lai

        if (transformEnemy.position.y > upLeftCap.position.y)
        {
            rbEnemy.velocity = new Vector2(speed * isMinus, -speed);
        }
    }

    public void Move2()
    {
        #region
        if (transformEnemy.position.x >= downRightCap.position.x)
        {
            isMoveRight = false;
        }

        if (transformEnemy.position.x <= upLeftCap.position.x)
        {
            isMoveRight = true;
        }

        if (isMoveRight)
        {
            rbEnemy.velocity = new Vector2(speed, rbEnemy.velocity.y);
        }
        else
        {
            rbEnemy.velocity = new Vector2(-speed, rbEnemy.velocity.y);
        }
        #endregion

        #region
        if (transformEnemy.position.y >= upLeftCap.position.y)
        {
            isMoveUp = false;
        }
        if (transformEnemy.position.y <= downRightCap.position.y)
        {
            isMoveUp = true;
        }

        if (isMoveUp)
        {
            rbEnemy.velocity = new Vector2(rbEnemy.velocity.x, speed);
        }
        else
        {
            rbEnemy.velocity = new Vector2(rbEnemy.velocity.x, -speed);
        }
        #endregion

    }
}
