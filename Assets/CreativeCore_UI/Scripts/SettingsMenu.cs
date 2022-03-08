using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void Maximize()
    {
        animator.SetTrigger("Open");
    }

    public void Minimize()
    {
        animator.SetTrigger("Close");
    }
}
