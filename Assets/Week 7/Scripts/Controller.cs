using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public Slider chargeSlider;
    float charge;
    public float maxCharge;
    Vector2 direction;
    public static Player CurrentSelection { get; private set; }

   void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }



    public static void SetCurrentSelection(Player player)
    {
      if(CurrentSelection != null)
    {
        CurrentSelection.Selected(false);
    }

CurrentSelection = player;
CurrentSelection.Selected(true);
      //  Debug.Log(CurrentSelection.name);
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            CurrentSelection.Move(direction);
            direction = Vector2.zero;
           // Debug.Log("This thing is working");
        }
    }


    private void Update()
    {
        if (CurrentSelection == null) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            charge = 0;
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            charge += Time.deltaTime;
            charge = Mathf.Clamp(charge, 0, maxCharge); 
            chargeSlider.value = charge;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)CurrentSelection.transform.position).normalized * charge;
           // Debug.Log(direction);
        }

        scoreText.text = "SCORE : " + score;
    }

}
