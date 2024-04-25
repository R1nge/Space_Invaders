using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay.Enemy;
using _Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Gameplay
{
    public class BulletView : MonoBehaviour
    {
        [SerializeField] private BulletConfig bulletConfig;
        private BulletController _bulletController;
        [Inject] private ResetService _resetService;
        private bool _collided;

        private void Start()
        {
            _bulletController = new BulletController(transform);
            _resetService.AddBullet(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_collided) return;

            if (other.TryGetComponent<EnemyView>(out var enemy))
            {
                _collided = true;
                _resetService.RemoveBullet(gameObject);
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