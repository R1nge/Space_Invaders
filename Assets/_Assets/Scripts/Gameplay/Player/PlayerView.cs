using _Assets.Scripts.Configs;
using _Assets.Scripts.Services;
using _Assets.Scripts.Services.Factories;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform origin;
        [SerializeField] private PlayerConfig playerConfig;
        private PlayerMovementController _playerMovementController;
        private WeaponController _weaponController;
        [Inject] private BulletFactory _bulletFactory;
        [Inject] private InputService _inputService;

        public void Init()
        {
            _playerMovementController = new PlayerMovementController(transform);
            _playerMovementController.Init(playerConfig.HorizontalClamp, playerConfig.VerticalClamp);
            _weaponController = new WeaponController(_bulletFactory);
            _inputService.OnShootPrimary += ShootPrimary;
            _inputService.OnShootSecondary += ShootSecondary;
        }

        private void ShootPrimary() => _weaponController.Shoot(origin.position, WeaponController.BulletType.Regular);

        private void ShootSecondary() => _weaponController.Shoot(origin.position, WeaponController.BulletType.Rare);

        private void Update()
        {
            _playerMovementController.Move(playerConfig.Speed, GetInput(), Time.deltaTime);
        }

        private Vector3 GetInput()
        {
            var horizontal = _inputService.Horizontal;
            var vertical = _inputService.Vertical;
            return new Vector3(horizontal, vertical, 0);
        }

        private void OnDestroy()
        {
            _inputService.OnShootPrimary -= ShootPrimary;
            _inputService.OnShootSecondary -= ShootSecondary;
        }
    }
}