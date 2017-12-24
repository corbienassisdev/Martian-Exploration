using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    void Start()
    {
        GiveMission();
    }

    public void GiveMission ()
    {
        Debug.Log("Hello Agent 247. Yesturday you forgot your hammer next to the external generator. Today, your mission is to get your hammer back, and come back to the martian module.");
    }
}
