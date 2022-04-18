using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class placedRecord : MonoBehaviour
{
    public AudioSource song;
    public AudioSource mainMusic;
    XRSocketInteractor socket;
    public GameObject record;
    public GameObject slider;
    public static bool recordPlaced;
    //public bool startScreen;
    
       
    // Start is called before the first frame update
    void Start()
    {
        
        
        socket = GetComponent<XRSocketInteractor>();


        socket.onSelectEnter.AddListener(OnSocketEnter);
        socket.onSelectExit.AddListener(OnSocketExit);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnSocketEnter(XRBaseInteractable socketEnter)
    {
        if (socketEnter.gameObject.CompareTag("115"))
        {
            recordPlaced = true;
            slider.SetActive(true);
            song.Play();
            mainMusic.Pause();
            winCondition.song = true;
            //record.transform.Rotate(0, transform.rotation.y * 3f, 0);
        }
        if (socketEnter.gameObject.CompareTag("Menu"))
        {
            //slider.SetActive(true);
            song.Play();
            mainMusic.Pause();
            winCondition.song = true;
            //record.transform.Rotate(0, transform.rotation.y * 3f, 0);
        }
    }
    void OnSocketExit(XRBaseInteractable socketExit)
    {
        if (socketExit.gameObject.CompareTag("115"))
        {
            mainMusic.Play();
            recordPlaced = false;
            slider.SetActive(false);
            song.Pause();
        }
        if (socketExit.gameObject.CompareTag("Menu"))
        {
            mainMusic.Play();
            //recordPlaced = false;
            slider.SetActive(false);
            song.Pause();
        }
    }
}
