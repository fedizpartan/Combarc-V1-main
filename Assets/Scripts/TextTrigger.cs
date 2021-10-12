using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour

    
{

    public GameObject UiObject;
    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UiObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        Destroy(Cube);
    }
}
