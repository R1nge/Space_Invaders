using System.Collections.Generic;

namespace _Assets.Scripts.Services.UIs.StateMachine
{
    public class UIStateMachine : GenericStateMachine<UIStateType, IState>
    {
        private UIStateMachine(UIStatesFactory uiStatesFactory)
        {
            States = new Dictionary<UIStateType, IState>
            {
                { UIStateType.Loading, uiStatesFactory.CreateState(UIStateType.Loading, this) },
                { UIStateType.Game, uiStatesFactory.CreateState(UIStateType.Game, this) }
            };
        }
    }
}