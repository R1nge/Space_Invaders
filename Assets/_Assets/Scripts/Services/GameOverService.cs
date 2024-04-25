using _Assets.Scripts.Services.StateMachine;
using UniRx;

namespace _Assets.Scripts.Services
{
    public class GameOverService
    {
        private readonly EnemyCounter _enemyCounter;
        private GameStateMachine _gameStateMachine;

        private GameOverService(EnemyCounter enemyCounter)
        {
            _enemyCounter = enemyCounter;
        }

        public void Init(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            _enemyCounter.OnCountChanged += TryGameOver;
        }

        private void TryGameOver(int count)
        {
            if (count == 0)
            {
                GameOver();
            }
        }

        public void GameOver()
        {
            _enemyCounter.OnCountChanged -= TryGameOver;
            _gameStateMachine.SwitchState(GameStateType.Game);
        }
    }
}