using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float secondsBeforeTickStarts = 5.0f;
    public float tickRateSeconds = 5.0f;

    void Start() { 
        InvokeRepeating("SendGameTick", secondsBeforeTickStarts, tickRateSeconds);
    }

    // Update is called once per frame
    void Update() { }

    void SendGameTick() {
        foreach(PatchController patch in this.GetPatches()) {
            Debug.Log("Tick");
            patch.Tick();
        }
    }

    private Component[] GetPatches() {
        return GetComponentsInChildren<PatchController>();
    }
}
