using _Assets.Scripts.Services.StateMachine;
using _Assets.Scripts.Services.UIs.StateMachine;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _Assets.Scripts.Services.UIs
{
    public class PauseUIView : MonoBehaviour
    {
        [SerializeField] private Button resumeButton;
        [SerializeField] private Button restartButton;
        [Inject] private GameStateMachine _gameStateMachine;
        [Inject] private UIStateMachine _uiStateMachine;

        private void Start()
        {
            resumeButton.onClick.AddListener(Resume);
            restartButton.onClick.AddListener(Restart);
        }

        private void Resume() => _uiStateMachine.SwitchState(UIStateType.Game);

        private void Restart() => _gameStateMachine.SwitchState(GameStateType.Game);

        private void OnDestroy()
        {
            resumeButton.onClick.RemoveListener(Resume);
            restartButton.onClick.RemoveListener(Restart);
        }
    }
}