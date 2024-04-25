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
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private Button pauseButton;
        [Inject] private ScoreService _scoreService;
        [Inject] private UIStateMachine _uiStateMachine;
        
        private void Start()
        {
            _scoreService.Score.Subscribe(score => scoreText.text = score.ToString()).AddTo(this);
            pauseButton.onClick.AddListener(Pause);
        }

        private void Pause() => _uiStateMachine.SwitchState(UIStateType.Pause);

        private void OnDestroy() => pauseButton.onClick.RemoveListener(Pause);
    }
}