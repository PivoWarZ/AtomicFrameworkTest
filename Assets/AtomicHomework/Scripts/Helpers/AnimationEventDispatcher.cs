using System;
using UnityEngine;

namespace ZombieShooter
{
    public class AnimationEventDispatcher: MonoBehaviour
    {
        public event Action<string> OnEventReceived;

        public void ReceiveEvent(string eventName)
        {
            OnEventReceived?.Invoke(eventName);
        }
    }
}

