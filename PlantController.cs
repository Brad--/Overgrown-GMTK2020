using System.Collections;
using UnityEngine;

// Plant Controller controls the sprite rendering for the plant, game logic is on PlotController
public class PlantController : MonoBehaviour {

    public Sprite tomato;
    public Sprite blueberry;
    public Sprite potato;
    public Sprite seedling;
    public Sprite growing;
    public Sprite grown;

    private SpriteRenderer plantBodyRenderer;
    private SpriteRenderer plantHeadRenderer;

    private Transform plantBodyTransform;
    private Transform plantHeadTransform;
    void Start() {
        // Get Child SpriteRenderers
        foreach(SpriteRenderer renderer in GetComponentsInChildren<SpriteRenderer>()) {
            if (renderer.name.Contains("head")) {
                this.plantHeadRenderer = renderer;
            }
            if (renderer.name.Contains("body")) {
                this.plantBodyRenderer = renderer;
            }
        }

        // Get Child Transforms
        foreach(Transform transform in GetComponentsInChildren<Transform>()) {
            if (transform.name.Contains("head")) {
                this.plantHeadTransform = transform;
            }
            if (transform.name.Contains("body")) {
                this.plantBodyTransform = transform;
            }
        }
    }

    public void SetSeedling() {
        plantBodyRenderer.sprite = this.seedling;
        // TODO set seedling transform
        platbody
    }

    public void SetBlueberry() {

    }

    public void SetGrownBody() {

    }
}