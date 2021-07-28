using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject sampleIcon;
    private Icon selected = null;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(selected == null)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if(Physics2D.Raycast(new Vector2(mousePos.x, mousePos.y), Vector2.zero, 0f))
                {
                    //do nothing
                }
                else
                {
                    GameObject.Instantiate(sampleIcon, mousePos, Quaternion.identity);
                }
            }
        }
        else if(Input.GetMouseButton(1))
        {
            if (selected)
                selected.GetComponent<Transform>().position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePos.x, mousePos.y), Vector2.zero, 0f);
            if(hit)
            {
                if (selected != null)
                    selected.DeselectIcon();

                selected = hit.transform.gameObject.GetComponent<Icon>();
                selected.SelectIcon();
            }
            else
            {
                if(selected != null)
                {
                    selected.DeselectIcon();
                    selected = null;
                }
            }
        }
    }
}
