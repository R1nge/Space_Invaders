using _Assets.Scripts.Services.Factories;
using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class WeaponController
    {
        private readonly BulletFactory _bulletFactory;

        public WeaponController(BulletFactory bulletFactory)
        {
            _bulletFactory = bulletFactory;
        }

        public void Shoot(Vector3 origin, BulletType bulletType)
        {
            _bulletFactory.Create(origin, bulletType);
        }

        public enum BulletType
        {
            Regular,
            Rare
        }
    }
}