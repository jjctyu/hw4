using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    EventScheduler scheduler;

    // Start is called before the first frame update
    void Start()
    {
        scheduler = GetComponent<EventScheduler>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left-click.");
        }
            


    }
}
