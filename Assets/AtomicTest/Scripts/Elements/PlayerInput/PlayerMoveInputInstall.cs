using System;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class PlayerMoveInputInstall: IEntityInstaller
    {
        [SerializeField] private KeyCode _forward;
        [SerializeField] private KeyCode _left;
        [SerializeField] private KeyCode _right;
        [SerializeField] private KeyCode _down;

        public void Install(IEntity entity)
        {
            entity.AddForwardDirectionInput(_forward);
            entity.AddLeftDirectionInput(_left);
            entity.AddRightDirectionInput(_right);
            entity.AddDownDirectionInput(_down);
        }
    }
}
