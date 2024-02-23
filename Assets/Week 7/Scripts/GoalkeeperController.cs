using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    public static GoalkeeperController singleton;
    private Rigidbody2D goalkeeperRigidbody2D; 
    public Transform centerOfGoal;
    internal Transform selectedPlayer;
    public float distanceOffGoalLine = 2f;


    void Awake()
    {
         if (singleton != null && singleton != this)
        {
        Destroy(this.gameObject);
        }
        singleton = this;   
    }


    // Start is called before the first frame update
    void Start()
    {
     goalkeeperRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectPlayer(Transform P)
    {
        selectedPlayer = P;
        Debug.Log("This function has been called once"); 
    }
}
