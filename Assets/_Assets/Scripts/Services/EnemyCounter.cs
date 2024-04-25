using System;
using UniRx;

namespace _Assets.Scripts.Services
{
    public class EnemyCounter
    {
        public int Count { get; private set; }
        
        public event Action<int> OnCountChanged;

        public void Set(int value)
        {
            Count = value;
        }

        public void Add()
        {
            Count++;
            OnCountChanged?.Invoke(Count);
        }

        public void Remove()
        {
            Count--;
            OnCountChanged?.Invoke(Count);
        }
    }
}