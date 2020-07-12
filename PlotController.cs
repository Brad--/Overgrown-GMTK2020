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

    public void Tick() {
        if (this.plant) {
            this.plant.Tick();
        }
    }

    private void SeedPlant(Plant plant) {
        this.plant = plant;
        this.plant.Seed();
    }

    public void OnMouseDown() {
        this.SeedPlant(gameObject.AddComponent(typeof(Tomato)) as Tomato);
    }
}
