using System;
using Atomic.Extensions;
using UnityEngine;

namespace ZombieShooter
{
    [Serializable]

    public class ParticlesContainer

    {
        [SerializeField] private ParticleSystem _shootParticle;
        [SerializeField] private ParticleSystem _takeDamageParticle;
        [SerializeField] private ParticleSystem _stunParticle;
        [SerializeField] private ParticleSystem _deathParticle;

        public ParticleSystem ShootParticle => _shootParticle;
        public ParticleSystem TakeDamageParticle => _takeDamageParticle;
        public ParticleSystem StunParticle => _stunParticle;
        public ParticleSystem DeathParticle => _deathParticle;
    }
}