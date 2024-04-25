using _Assets.Scripts.Configs;
using UnityEngine;
using Zenject;

namespace _Assets.Scripts.CompositionRoot
{
    public class RootInstaller : MonoInstaller
    {
        [SerializeField] private ConfigProvider configProvider;

        public override void InstallBindings()
        {
            Container.BindInstance(configProvider);
        }
    }
}