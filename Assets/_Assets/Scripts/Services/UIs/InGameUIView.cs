using TMPro;
using UniRx;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Services.UIs
{
    public class InGameUIView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [Inject] private ScoreService _scoreService;
        
        private void Start() => _scoreService.Score.Subscribe(score => scoreText.text = score.ToString()).AddTo(this);
    }
}