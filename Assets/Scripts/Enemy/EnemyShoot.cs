using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private float shootRate;
    [SerializeField] private GameObject enemyBulletGroup;
    [SerializeField] private Transform transformEnemy;
    [SerializeField] private EnemyMovement enemyMovement;
    private void Update()
    {
        if (timer.IsCompleted && enemyMovement.CanMove)
        {
            Instantiate(enemyBulletGroup, transformEnemy.position, transformEnemy.rotation);
            timer.setTime(shootRate);
        }
    }
}
