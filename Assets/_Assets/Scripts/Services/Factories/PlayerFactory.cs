using _Assets.Scripts.Configs;
using _Assets.Scripts.Gameplay.Player;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Services.Factories
{
    public class PlayerFactory
    {
        private readonly DiContainer _diContainer;
        private readonly ConfigProvider _configProvider;

        private PlayerFactory(DiContainer diContainer, ConfigProvider configProvider)
        {
            _diContainer = diContainer;
            _configProvider = configProvider;
        }

        public PlayerView Create(Vector3 position)
        {
            var player = _diContainer.InstantiatePrefabForComponent<PlayerView>(_configProvider.PlayerPrefab, position, Quaternion.identity, null);
            player.Init();
            return player;
        }
    }
}