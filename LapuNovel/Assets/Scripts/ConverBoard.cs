using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConverBoard : MonoBehaviour
{
    public string title;
    public string context;
    public Image img;

    public ConverBoard next;
    public ChoicePointer chp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (next != null)
            {
                next.gameObject.SetActive(true);
            }
            else if (chp != null)
            {
                chp.gameObject.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
