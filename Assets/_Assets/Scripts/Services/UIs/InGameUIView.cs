using _Assets.Scripts.Services.UIs.StateMachine;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _Assets.Scripts.Services.UIs
{
    public class InGameUIView : MonoBehaviour
    {
        [SerializeField] private Button shootPrimary, shootSecondary;
        [SerializeField] private Joystick joystick;
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private Button pauseButton;
        [Inject] private ScoreService _scoreService;
        [Inject] private UIStateMachine _uiStateMachine;
        [Inject] private InputService _inputService;
        
        private void Start()
        {
            _scoreService.Score.Subscribe(score => scoreText.text = score.ToString()).AddTo(this);
            pauseButton.onClick.AddListener(Pause);
            _inputService.Init(joystick, shootPrimary, shootSecondary);
        }

        private void Pause() => _uiStateMachine.SwitchState(UIStateType.Pause);

        private void OnDestroy() => pauseButton.onClick.RemoveListener(Pause);
    }
}