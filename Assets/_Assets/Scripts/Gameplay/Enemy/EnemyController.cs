using _Assets.Scripts.Services;

namespace _Assets.Scripts.Gameplay.Enemy
{
    public class EnemyController
    {
        private readonly ResetService _resetService;
        private readonly ScoreService _scoreService;
        private readonly EnemyView _enemyView;
        private readonly EnemyCounter _enemyCounter;

        public EnemyController(ResetService resetService, ScoreService scoreService, EnemyView enemyView, EnemyCounter enemyCounter)
        {
            _resetService = resetService;
            _scoreService = scoreService;
            _enemyView = enemyView;
            _enemyCounter = enemyCounter;
        }

        public void Init()
        {
            _resetService.AddEnemy(_enemyView);
            _enemyCounter.Add();
        }

        public void Die()
        {
            _resetService.RemoveEnemy(_enemyView);
            _scoreService.AddScore(_enemyView.Score);
            _enemyCounter.Remove();
        }
    }
}