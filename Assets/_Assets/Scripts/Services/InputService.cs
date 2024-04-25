using System;
using UnityEngine.UI;

namespace _Assets.Scripts.Services
{
    public class InputService
    {
        private Joystick _joystick;
        private Button _shootPrimary;
        private Button _shootSecondary;

        public event Action OnShootPrimary;
        public event Action OnShootSecondary;

        public void Init(Joystick joystick, Button shootPrimary, Button shootSecondary)
        {
            _joystick = joystick;
            _shootPrimary = shootPrimary;
            _shootSecondary = shootSecondary;

            _shootPrimary.onClick.AddListener(ShootPrimary);
            _shootSecondary.onClick.AddListener(ShootSecondary);
        }

        private void ShootPrimary() => OnShootPrimary?.Invoke();

        private void ShootSecondary() => OnShootSecondary?.Invoke();

        public float Horizontal => _joystick == null ? 0 : _joystick.Horizontal;

        public float Vertical => _joystick == null ? 0 : _joystick.Vertical;
    }
}