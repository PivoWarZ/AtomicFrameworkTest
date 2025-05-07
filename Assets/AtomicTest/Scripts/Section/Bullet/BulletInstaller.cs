using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{

    public class BulletInstaller : SceneEntityInstallerBase, IEntityInit
    {
        [SerializeField] private TransformInstall _bulletTransform;
        [SerializeField] private MoveInstall _moveInstall;
        [SerializeField] private float _timeToDestroy = 5f;

        public override void Install(IEntity entity)
        {
            _bulletTransform.Install(entity);
            _moveInstall.Install(entity);

            entity.AddBehaviour(new MoveBehavior());
        }

        void IEntityInit.Init(IEntity entity)
        {
            Destroy(gameObject, _timeToDestroy);
        }
    }
}
