using _Assets.Scripts.Configs;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private PlayerConfig playerConfig;
        private PlayerMovementController _playerMovementController;

        private void Start()
        {
            _playerMovementController = new PlayerMovementController(transform);
            
            _playerMovementController.Init(playerConfig.HorizontalClamp, playerConfig.VerticalClamp);
        }

        private void Update()
        {
            _playerMovementController.Move(playerConfig.Speed, GetInput(), Time.deltaTime);
        }

        private Vector3 GetInput()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, vertical, 0);
        }
    }
}