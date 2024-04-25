using System;
using _Assets.Scripts.Services.Factories;
using _Assets.Scripts.Services.StateMachine.States;
using _Assets.Scripts.Services.UIs.StateMachine;

namespace _Assets.Scripts.Services.StateMachine
{
    public class GameStatesFactory
    {
        private readonly UIStateMachine _uiStateMachine;
        private readonly PlayerFactory _playerFactory;
        private readonly EnemyFactory _enemyFactory;
        private readonly ResetService _resetService;
        private readonly GameOverService _gameOverService;
        private readonly EnemyCounter _enemyCounter;

        private GameStatesFactory(UIStateMachine uiStateMachine, PlayerFactory playerFactory, EnemyFactory enemyFactory,
            ResetService resetService, GameOverService gameOverService, EnemyCounter enemyCounter)
        {
            _uiStateMachine = uiStateMachine;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
            _resetService = resetService;
            _gameOverService = gameOverService;
            _enemyCounter = enemyCounter;
        }

        public IState CreateState(GameStateType gameStateType, GameStateMachine gameStateMachine)
        {
            switch (gameStateType)
            {
                case GameStateType.Game:
                    return new GameState(gameStateMachine, _playerFactory, _enemyFactory, _resetService,
                        _uiStateMachine, _gameOverService);
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameStateType), gameStateType, null);
            }
        }
    }
}