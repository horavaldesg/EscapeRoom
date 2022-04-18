using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winCondition : MonoBehaviour
{
    public static bool win;
    public static bool doorState = false;
    public static bool song = false;
    public static bool passwordState = false;

    public TextMesh doorText;
    public TextMesh songText;
    public TextMesh passwordText;
    // Start is called before the first frame update
    void Awake()
    {
        doorState = false;
        song = false;
        passwordState = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorState == true && song == true && passwordState == true)
        {
            SceneManager.LoadScene("Win");
        }
        doorText.text = doorState.ToString();
        songText.text = song.ToString();
        passwordText.text = passwordState.ToString();
    }
}
