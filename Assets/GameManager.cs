using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KYapp.Cshchat;
using System.Text.RegularExpressions;
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

    public GameObject WordPrefab;
    public GameObject Words;
    // Start is called before the first frame update
    void Start()
    {
        TitlePanel.SetActive(true);
        GamePanel.SetActive(false);
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
        Match a = Regex.Match(com.text, @"‰¹—Ê\(0\)(.+?)");
        if (a.Success)
        {
            Debug.Log("aaaaaa");
            GameObject go = Instantiate(WordPrefab).transform.GetChild(0).gameObject;
            //TMP_Text text = go.GetComponent<TMP_Text>();
            //text.text = a.Groups[1].Value;
        }
    }

    public void OnDestroy()
    {
        youtubeLive.End();
    }
}
