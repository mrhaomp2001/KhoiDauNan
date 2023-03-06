using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private Text textDialog;
    [SerializeField] private Animator animator;
    public string TextDialog { get => textDialog.text; set => textDialog.text = value; }

    public void SetAnimDialog(bool value)
    {
        animator.SetBool("isStart", value);
    }
}
