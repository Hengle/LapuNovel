using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBoardController : MonoBehaviour
{
    public bool isAutoPlay = false;

    public ConverBoard startBoard;

    public GameObject startBtn;

    // Start is called before the first frame update
    void Start()
    {
        startBtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        startBoard.gameObject.SetActive(true);
        Destroy(GameObject.Find("GameStart"));
    }
}
