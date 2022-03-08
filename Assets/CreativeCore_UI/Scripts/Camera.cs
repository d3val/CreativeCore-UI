using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Animator animator;



    public void SettingsMenuView()
    {
        animator.SetTrigger("SettingsMenu");
    }

    public void ReturnInitialPosition()
    {
        animator.SetTrigger("ReturnInitialPosition");
    }
}