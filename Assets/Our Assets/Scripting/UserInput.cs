using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    [SerializeField]
    EventScheduler scheduler;

    [SerializeField]
    private GameObject context;
    [SerializeField]
    private GameObject option1;
    [SerializeField]
    private GameObject option2;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left-click.");
            progress();
        }
            


    }

    // Render the next UI page
    private void progress()
    {
        Dialogue d = scheduler.getNextEvent();
        // render this dialogue on the canvas
        if (d != null)
        {
            Debug.Log("here in progress");
            TMPro.TextMeshProUGUI tmpContext = context.GetComponent<TMPro.TextMeshProUGUI>();
            tmpContext.SetText(d.text);
            option1.GetComponentInChildren<TMPro.TextMeshProUGUI>().SetText(d.options[0]);
            option2.GetComponentInChildren<TMPro.TextMeshProUGUI>().SetText(d.options[1]);
        }
        else
        {
            //no event, story is ending

        }

    }

    public void ClickOption1()
    {
        // getting the feedback info and following state change.

        // test to print 1 now
        Debug.Log("option 1");
    }
}
