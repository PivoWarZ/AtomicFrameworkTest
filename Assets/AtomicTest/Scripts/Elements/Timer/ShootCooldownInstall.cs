using Atomic.Elements;
using Atomic.Entities;

namespace testAtomic
{
    public class ShootCooldownInstall: IEntityInstaller
    {
        private ReactiveVariable<bool> _cooldown;
        void IEntityInstaller.Install(IEntity entity)
        {
           
        }
    }
}