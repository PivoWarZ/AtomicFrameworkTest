using Atomic.Contexts;
using Atomic.Entities;

namespace ZombieShooter
{
    public class SetEnemyBehavior: IContextInit, IContextEnable, IContextDispose
    {
        private SpawnerContextInstaller _spawner;
        private ServiceLocator _serviceLocator;
        void IContextInit.Init(IContext context)
        {
            _spawner = context.GetSpawner();
            _serviceLocator = context.GetServiceLocator();
        }

        void IContextEnable.Enable(IContext context)
        {
            _spawner.OnSpawnEvent.Subscribe(SetEnemy);
        }

        private void SetEnemy(IEntity entity)
        {
            //entity.GetLoockAtTransform() = _serviceLocator.Player.transform;
            entity.GetEntityTransform().gameObject.SetActive(true);
        }
        
        void IContextDispose.Dispose(IContext context)
        {
            _spawner.OnSpawnEvent.Unsubscribe(SetEnemy);
        }
    }
}