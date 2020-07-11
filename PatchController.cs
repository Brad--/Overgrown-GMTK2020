using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Tick() {
        Debug.Log("how many plots: " + this.GetPlots());
    }

    public void OnMouseDown() {
        this.Tick();
    }

    public Component[] GetPlots() {
        // Should this save to a local var?
        return GetComponentsInChildren<PlotController>();
    }
}
