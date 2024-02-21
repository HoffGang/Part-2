using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class Player: MonoBehaviour
{
    SpriteRenderer sr;
    public Color selectedColor;
    public Color unselectedColor;


    // Start is called before the first frame update
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Selected(false);
    }

    private void OnMouseDown()
    {
        Selected(true);
    }

  

    public void Selected (bool isSelected)
    {
        if (isSelected)
        {
            sr.color = selectedColor;
        }

        else
        {
            sr.color = unselectedColor;
        }
            
        

    }
}
