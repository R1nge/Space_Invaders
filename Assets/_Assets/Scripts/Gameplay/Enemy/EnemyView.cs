using _Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Gameplay.Enemy
{
    public class EnemyView : MonoBehaviour
    {
        [Inject] private ResetService _resetService;

        private void Start() => _resetService.AddEnemy(this);

        public void Die()
        {
            _resetService.RemoveEnemy(this);
            Destroy(gameObject);
        }
    }
}