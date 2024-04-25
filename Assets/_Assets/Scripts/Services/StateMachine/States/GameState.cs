using _Assets.Scripts.Services.Factories;
using UnityEngine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly PlayerFactory _playerFactory;
        private readonly EnemyFactory _enemyFactory;

        public GameState(GameStateMachine stateMachine, PlayerFactory playerFactory, EnemyFactory enemyFactory)
        {
            _stateMachine = stateMachine;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
        }

        public void Enter()
        {
            _enemyFactory.CreateRow(new Vector3(-8, 4, 10), 16, 1);
            _playerFactory.Create(new Vector3(0, -4, 10));
        }

        public void Exit()
        {
        }
    }
}