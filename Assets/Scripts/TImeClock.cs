using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TImeClock : MonoBehaviour
{
    public TextMeshPro time;
    

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(myTime.TimeOfDay);

    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime myTime = System.DateTime.Now;
        string timeFormat = myTime.Hour.ToString("##:") + myTime.Minute.ToString();
        if (placedRecord.recordPlaced)
        {
            time.text = "1:15";
        }
        else
        {
            time.text = timeFormat;
        }
    }
}
