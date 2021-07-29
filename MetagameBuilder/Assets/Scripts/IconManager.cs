using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconManager : MonoBehaviour
{
    private static IconManager instance = null;
    public static IconManager Instance { get { return instance; } }

    public List<Icon> iconList;
    public Icon selectedIcon = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    //function to select a Icon
}
