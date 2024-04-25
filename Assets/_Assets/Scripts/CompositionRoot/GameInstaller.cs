using _Assets.Scripts.Services.Factories;
using _Assets.Scripts.Services.StateMachine;
using _Assets.Scripts.Services.UIs;
using _Assets.Scripts.Services.UIs.StateMachine;
using Zenject;

namespace _Assets.Scripts.CompositionRoot
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<BulletFactory>().AsSingle();
            
            Container.Bind<PlayerFactory>().AsSingle();
            Container.Bind<EnemyFactory>().AsSingle();
            
            Container.Bind<UIStatesFactory>().AsSingle();
            Container.Bind<UIStateMachine>().AsSingle();
            Container.Bind<UIFactory>().AsSingle();
            
            Container.Bind<GameStatesFactory>().AsSingle();
            Container.Bind<GameStateMachine>().AsSingle();
        }
    }
}