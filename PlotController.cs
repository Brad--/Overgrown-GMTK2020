using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotController : MonoBehaviour
{
    private Plant plant;
    

    // Start is called before the first frame update
    void Start(){ }

    // Update is called once per frame
    void Update(){ }

    void Tick() {
        this.plant.Tick();
    }

    private void SeedPlant(Plant plant) {
        this.plant = plant;
        this.plant.Seed();
    }

    public void OnMouseDown() {
        Debug.Log("ya clicked me, " + this.name);
        this.SeedPlant(new Tomato());
    }
}
