using UnityEngine;

namespace _Assets.Scripts.Services.UIs.StateMachine.States
{
    public class UIPauseState : IState
    {
        private readonly UIFactory _uiFactory;
        private GameObject _ui;

        public UIPauseState(UIFactory uiFactory) => _uiFactory = uiFactory;

        public void Enter() => _ui = _uiFactory.CreateUI(UIStateType.Pause);

        public void Exit() => Object.Destroy(_ui);
    }
}