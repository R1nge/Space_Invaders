using UniRx;
using UnityEngine;

namespace _Assets.Scripts.Services
{
    public class ScoreService
    {
        public ReactiveProperty<int> Score { get; } = new();

        public void AddScore(int score)
        {
            if (score <= 0)
            {
                Debug.LogWarning("Trying to add negative score");
                return;
            }

            Score.Value += score;
        }
    }
}