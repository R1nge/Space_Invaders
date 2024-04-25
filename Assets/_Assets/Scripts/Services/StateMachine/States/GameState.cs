using _Assets.Scripts.Services.Factories;
using _Assets.Scripts.Services.UIs.StateMachine;
using UnityEngine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly PlayerFactory _playerFactory;
        private readonly EnemyFactory _enemyFactory;
        private readonly ResetService _resetService;
        private readonly UIStateMachine _uiStateMachine;

        public GameState(GameStateMachine stateMachine, PlayerFactory playerFactory, EnemyFactory enemyFactory,
            ResetService resetService, UIStateMachine uiStateMachine)
        {
            _stateMachine = stateMachine;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
            _resetService = resetService;
            _uiStateMachine = uiStateMachine;
        }

        public void Enter()
        {
            var enemies = _enemyFactory.CreateRow(new Vector3(-8, 4, 10), 16, 1);
            var player = _playerFactory.Create(new Vector3(0, -4, 10));
            
            _resetService.SetPlayer(player);
            _resetService.SetEnemies(enemies);

            _uiStateMachine.SwitchState(UIStateType.Game);
        }

        public void Exit()
        {
            _resetService.Reset();
        }
    }
}