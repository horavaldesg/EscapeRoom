using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rotateHour : MonoBehaviour
{
    //public TextMesh rotationText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Rotate(Time.deltaTime * 1.5f, 0, 0);

        if (gameObject.transform.localRotation.x < 0)
        {
            SceneManager.LoadScene("EndScreen");
        }
        //rotationText.text = gameObject.transform.localRotation.x.ToString();
    }
}
