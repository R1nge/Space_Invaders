using System.Collections.Generic;
using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay.Enemy;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Services.Factories
{
    public class EnemyFactory
    {
        private readonly DiContainer _diContainer;
        private readonly ConfigProvider _configProvider;

        private EnemyFactory(DiContainer diContainer, ConfigProvider configProvider)
        {
            _diContainer = diContainer;
            _configProvider = configProvider;
        }

        public List<EnemyView> CreateRow(Vector3 origin, int count, float offsetX = 0f)
        {
            var enemyViews = new List<EnemyView>();

            for (int i = 0; i < count; i++)
            {
                var position = new Vector3(origin.x + i * offsetX, origin.y, origin.z);
                var enemyView = Create(position);
                enemyViews.Add(enemyView);
            }

            return enemyViews;
        }

        public EnemyView Create(Vector3 position)
        {
            var enemyView =
                _diContainer.InstantiatePrefabForComponent<EnemyView>(
                    _configProvider.EnemyPrefab,
                    position,
                    Quaternion.identity,
                    null
                );
            
            return enemyView;
        }
    }
}