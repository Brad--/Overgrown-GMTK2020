using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void Tick() {
        foreach(PlotController plot in this.GetPlots()) {
            plot.Tick();
        }
    }

    public void OnMouseDown() {
        this.Tick();
    }

    public Component[] GetPlots() {
        return GetComponentsInChildren<PlotController>();
    }
}
