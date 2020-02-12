using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public string context;
    public ChoicePointer nextCP;
    public ConverBoard nextCB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBtn()
    {
        if (nextCP != null)
        {
            nextCP.gameObject.SetActive(true);
        }
        else if (nextCB != null)
        {
            nextCB.gameObject.SetActive(true);
        }
        Destroy(gameObject.transform.parent.gameObject);
    }
}
