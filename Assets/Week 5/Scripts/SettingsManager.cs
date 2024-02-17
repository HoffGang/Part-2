using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SixteenByNine ()
    {
        Screen.SetResolution(16, 9, false);
     }

    public void FullHD()
    {
        Screen.SetResolution(1920, 1080, false);
    }

   public void Counter()
    {
        float count = PlayerPrefs.GetFloat("Count");

        PlayerPrefs.SetFloat("Count", count + 1);

      
    }


}
