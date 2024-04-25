using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class BulletController
    {
        private Transform _transform;
        
        public BulletController(Transform transform)
        {
            _transform = transform;
        }
        
        public void Move(float speed, float delta)
        {
            _transform.Translate(Vector3.up * speed * delta);
        }
    }
}