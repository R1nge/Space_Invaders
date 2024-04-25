using _Assets.Scripts.Services.UIs.StateMachine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class InitState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly UIStateMachine _uiStateMachine;

        public InitState(GameStateMachine stateMachine, UIStateMachine uiStateMachine)
        {
            _stateMachine = stateMachine;
            _uiStateMachine = uiStateMachine;
        }

        public void Enter() => _uiStateMachine.SwitchState(UIStateType.Loading);

        public void Exit()
        {
        }
    }
}