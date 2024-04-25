using _Assets.Scripts.Services;

namespace _Assets.Scripts.Gameplay.Enemy
{
    public class EnemyController
    {
        private readonly ResetService _resetService;
        private readonly ScoreService _scoreService;
        private readonly EnemyView _enemyView;

        public EnemyController(ResetService resetService, ScoreService scoreService, EnemyView enemyView)
        {
            _resetService = resetService;
            _scoreService = scoreService;
            _enemyView = enemyView;
        }

        public void Init()
        {
            _resetService.AddEnemy(_enemyView);
        }

        public void Die()
        {
            _resetService.RemoveEnemy(_enemyView);
            _scoreService.AddScore(_enemyView.Score);
        }
    }
}