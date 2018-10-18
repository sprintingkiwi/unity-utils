using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{

    public Controller controller;
    
    [Header("Function")]
    public UnityEvent myUnityEvent;

    // Use this for initialization
    void Start ()
    {
        controller = GameObject.Find("Controller").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    public void OnMouseDown()
    {
        Debug.Log(name + " clicked");
        myUnityEvent.Invoke();
    }
}
