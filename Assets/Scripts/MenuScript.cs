using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    // Getting message from the database
    public void GetMessage()
    {
        Debug.Log("Here is your message =) ");
    }

    // Saving message to the database
    public void SendMessage(string message)
    {
        Debug.Log("Your message is saved =) ");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
