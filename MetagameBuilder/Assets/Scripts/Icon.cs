using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public string iconName;
    public int wins;
    public int loses;
    public int ties;

    Vector2 pos;
    SpriteRenderer iconImage;
    bool selected = false;


    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        iconImage = gameObject.GetComponent<SpriteRenderer>();

        gameObject.transform.position = new Vector3(pos.x, pos.y, 1f);
        IconManager.Instance.iconList.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        pos = gameObject.transform.position;
    }

    public bool IsSelected()
    {
        return selected;
    }

    public void SelectIcon()
    {
        if(!selected)
        {
            selected = true;
            iconImage.color = Color.red;
        }

    }

    public void DeselectIcon()
    {
        if(selected)
        {
            selected = false;
            iconImage.color = Color.white;
        }

    }
}
