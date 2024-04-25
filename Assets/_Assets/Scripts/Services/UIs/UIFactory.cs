using System;
using _Assets.Scripts.Configs;
using _Assets.Scripts.Services.UIs.StateMachine;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.Services.UIs
{
    public class UIFactory
    {
        private readonly DiContainer _container;
        private readonly ConfigProvider _configProvider;

        public UIFactory(DiContainer container, ConfigProvider configProvider)
        {
            _container = container;
            _configProvider = configProvider;
        }

        public GameObject CreateUI(UIStateType uiStateType)
        {
            switch (uiStateType)
            {
                case UIStateType.None:
                    break;
                case UIStateType.Game:
                    return _container.InstantiatePrefab(_configProvider.UIConfig.GameUI.gameObject);
                case UIStateType.Pause:
                    return _container.InstantiatePrefab(_configProvider.UIConfig.PauseUI.gameObject);
                default:
                    throw new ArgumentOutOfRangeException(nameof(uiStateType), uiStateType, null);
            }

            return null;
        }
    }
}