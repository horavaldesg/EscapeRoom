using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkButton : MonoBehaviour
{
    public static bool buttonCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonStatus()
    {
        buttonCheck = true;
        gameObject.SetActive(false);
    }
}
