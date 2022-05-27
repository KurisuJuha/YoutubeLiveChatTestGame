using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Cshchat;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject TitlePanel;
    public GameObject GamePanel;

    public bool IsStarted;

    public TMP_InputField liveIdInput;
    public TMP_InputField WordInput;

    public string liveID;

    YoutubeLive youtubeLive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStarted)
        {

        }
    }

    public void OnStartButton()
    {
        TitlePanel.SetActive(false);
        GamePanel.SetActive(true);

        youtubeLive = new YoutubeLive(liveIdInput.text);
        youtubeLive.Begin(OnComment);
    }

    public void OnComment(Comment com)
    {
        Debug.Log(com.text);
    }

    public void OnDestroy()
    {
        youtubeLive.End();
    }
}
