using System;
using _Assets.Scripts.Gameplay.Enemy;
using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class BulletView : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<EnemyView>(out var enemy))
            {
                enemy.Die();
            }
        }
    }
}