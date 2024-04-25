using _Assets.Scripts.Configs;
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

        public void Init()
        {
            _playerMovementController = new PlayerMovementController(transform);
            _playerMovementController.Init(playerConfig.HorizontalClamp, playerConfig.VerticalClamp);
            _weaponController = new WeaponController(_bulletFactory);
        }

        private void Update()
        {
            _playerMovementController.Move(playerConfig.Speed, GetInput(), Time.deltaTime);

            if (Input.GetMouseButtonDown(0))
            {
                _weaponController.Shoot(origin.position, WeaponController.BulletType.Regular);
            }

            if (Input.GetMouseButtonDown(1))
            {
                _weaponController.Shoot(origin.position, WeaponController.BulletType.Rare);
            }
        }

        private Vector3 GetInput()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, vertical, 0);
        }
    }
}