using Atomic.Contexts;
using UnityEngine;

namespace ZombieShooter
{
    public class ShootContext: SceneContextInstallerBase
    {
        [SerializeField] private ShootInput _shootInput;
        [SerializeField] private ShootController _controller;
        
        public override void Install(IContext context)
        {
           // context.AddPlayerShoot(_shootInput);
            
            _controller.Init(context);
            
            context.AddSystem(_shootInput);
        }
    }
}