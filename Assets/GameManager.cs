using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject TitlePanel;
    public GameObject GamePanel;

    public bool IsStarted;
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
    }
}
