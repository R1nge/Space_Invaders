using UnityEngine;

namespace _Assets.Scripts.Gameplay.Player
{
    public class PlayerMovementController
    {
        private bool _canMove;
        private readonly Transform _player;
        private Vector2 _startPosition;
        private Vector2 _relativeClampedPosition;

        public PlayerMovementController(Transform player)
        {
            _player = player;
        }

        public void Init(float horizontalClamp, float verticalClamp)
        {
            _relativeClampedPosition = new Vector2(_player.position.x + horizontalClamp, _player.position.y + verticalClamp);
            _startPosition = _player.position;
            _canMove = true;
        }

        public void Move(float speed, Vector3 direction, float delta)
        {
            if (!_canMove) return;
            
            _player.Translate(direction * (speed * delta));
            _player.position = ClampedPosition(_relativeClampedPosition.x, _relativeClampedPosition.y);
        }

        private Vector3 ClampedPosition(float horizontalClamp, float verticalClamp)
        {
            return new Vector3(
                Mathf.Clamp(_player.position.x, -horizontalClamp, horizontalClamp),
                Mathf.Clamp(_player.position.y, _startPosition.y, verticalClamp),
                _player.position.z
            );
        }
    }
}