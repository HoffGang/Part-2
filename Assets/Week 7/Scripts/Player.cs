using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using JetBrains.Annotations;
using UnityEditor;

public class Player: MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;
    public float speed = 100;
    public Color selectedColor;
    public Color unselectedColor;

    // Start is called before the first frame update
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }

    private void OnMouseDown()
    {
        Controller.SetCurrentSelection(this);
    }

    public void Selected(bool isSelected)
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


       public void Move(Vector2 direction)
        {
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
        Debug.Log (direction * speed);
        }
}

