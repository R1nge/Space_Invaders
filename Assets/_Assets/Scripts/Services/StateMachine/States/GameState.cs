using _Assets.Scripts.Services.Factories;
using UnityEngine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly PlayerFactory _playerFactory;

        public GameState(GameStateMachine stateMachine, PlayerFactory playerFactory)
        {
            _stateMachine = stateMachine;
            _playerFactory = playerFactory;
        }

        public void Enter()
        {
            _playerFactory.Create(new Vector3(0, -4, 10));
        }

        public void Exit()
        {
        }
    }
}