using UnityEngine;

namespace _Assets.Scripts.Services.UIs.StateMachine.States
{
    public class UILoadingState : IState
    {
        private readonly UIFactory _uiFactory;
        private readonly UIStateMachine _uiStateMachine;
        private GameObject _ui;

        public UILoadingState(UIFactory uiFactory, UIStateMachine uiStateMachine)
        {
            _uiFactory = uiFactory;
            _uiStateMachine = uiStateMachine;
        }

        public void Enter() => _ui = _uiFactory.CreateUI(UIStateType.Loading);

        public void Exit() => Object.Destroy(_ui);
    }
}