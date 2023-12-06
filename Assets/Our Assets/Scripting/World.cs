using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This file is used to record the world settings. 

public class World : MonoBehaviour
{

    int scene = 0;
    float distance = 0;
    float speed = 8;
    int sceneLength = 1920; //Change to 1920 - Mech width in pixels
    bool mechWalking = false;
    public GameObject background;
    public GameObject mech;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (mechWalking){
            moveObjects(Time.deltaTime);
        }
        if(distance >= sceneLength){ //this code will assume scene is tied to locations and not unity scenes
            /*if(scene < 2){
                scene++;
                //set distance to 0
                //change background to scene
                moveObjects (0);
            } else {
                //end event
            }
            */
        }
    }

    void moveObjects (float movement){

        distance+=speed*movement;

        /*var mechTrans = mech.GetComponent<Transform>();
        mechTrans.position.x = distance;
        mech.transform = mechTrans;

        var backgroundTrans = background.GetComponent<Transform>();
        backgroundTrans.position.x = -distance*(1920/sceneLength);
        background.transform = backgroundTrans;*/
    }
}
