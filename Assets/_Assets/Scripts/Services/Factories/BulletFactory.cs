using System;
using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Services.Factories
{
    public class BulletFactory
    {
        private readonly DiContainer _diContainer;
        private readonly ConfigProvider _configProvider;

        private BulletFactory(DiContainer diContainer, ConfigProvider configProvider)
        {
            _diContainer = diContainer;
            _configProvider = configProvider;
        }

        public void Create(Vector3 position, WeaponController.BulletType bulletType)
        {
            switch (bulletType)
            {
                case WeaponController.BulletType.Regular:
                    _diContainer.InstantiatePrefab(_configProvider.RegularBulletPrefab, position, Quaternion.identity, null);
                    break;
                case WeaponController.BulletType.Rare:
                    _diContainer.InstantiatePrefab(_configProvider.RareBulletPrefab, position, Quaternion.identity, null);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(bulletType), bulletType, null);
            }
            
        }
    }
}