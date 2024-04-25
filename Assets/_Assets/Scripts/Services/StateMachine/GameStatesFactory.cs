﻿using System;
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

        private GameStatesFactory(UIStateMachine uiStateMachine, PlayerFactory playerFactory, EnemyFactory enemyFactory, ResetService resetService)
        {
            _uiStateMachine = uiStateMachine;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
            _resetService = resetService;
        }

        public IState CreateState(GameStateType gameStateType, GameStateMachine gameStateMachine)
        {
            switch (gameStateType)
            {
                case GameStateType.Init:
                    return new InitState(gameStateMachine, _uiStateMachine);
                case GameStateType.Game:
                    return new GameState(gameStateMachine, _playerFactory, _enemyFactory, _resetService);
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameStateType), gameStateType, null);
            }
        }
    }
}