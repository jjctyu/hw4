using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manageMeters : MonoBehaviour
{
    public float value;
    public float max;
    public int decayRate;
    public GameObject text;
    public GameObject meter;
    // Start is called before the first frame update
    void Start()
    {
        updateVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tick(){
        value -= decayRate*Time.deltaTime;
        updateVisuals();
    }

    public void changeNumber (){
        updateVisuals();
    }

    private void updateVisuals(){
        text.GetComponent<TextMeshProUGUI>().text = value +"/"+max;
        meter.transform.localScale = new Vector3 (value/max,1,1);
    }
}
