using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParticleSystem : MonoBehaviour
{
    [SerializeField] ParticleSystem normalFire;
    [SerializeField] ParticleSystem disperseFire;

    public void StartDisperseFire()
    {
        disperseFire.Play();
        normalFire.Stop();
    }

    public void StartNormalFire()
    {
        disperseFire.Stop();
        normalFire.Play();
    }
}
