using System;
using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay.Enemy;
using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class BulletView : MonoBehaviour
    {
        [SerializeField] private BulletConfig bulletConfig;
        private BulletController _bulletController;

        private void Start()
        {
            _bulletController = new BulletController(transform);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent<EnemyView>(out var enemy))
            {
                enemy.Die();
                Destroy(gameObject);
            }
        }

        public void Update()
        {
            _bulletController.Move(bulletConfig.Speed, Time.deltaTime);
        }
    }
}