using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMenu : MonoBehaviour
{
    public GameObject optionUI;
    public GameObject statsUI;

    private Icon target;

    public void SetTarget(Icon _target)
    {
        target = _target;

        transform.position = target.transform.position;

        optionUI.SetActive(true);
        statsUI.SetActive(true);
    }

    public void Hide()
    {
        optionUI.SetActive(false);
        statsUI.SetActive(false);
    }
}
