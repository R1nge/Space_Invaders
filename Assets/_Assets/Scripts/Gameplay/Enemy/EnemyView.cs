using _Assets.Scripts.Services;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Gameplay.Enemy
{
    public class EnemyView : MonoBehaviour
    {
        [SerializeField] private int score;
        public int Score => score;
        [Inject] private ResetService _resetService;
        [Inject] private ScoreService _scoreService;
        private EnemyController _enemyController;

        private void Start()
        {
            _enemyController = new EnemyController(_resetService, _scoreService, this);
            _enemyController.Init();
        }

        public void Die()
        {
            _enemyController.Die();
            Destroy(gameObject);
        }
    }
}