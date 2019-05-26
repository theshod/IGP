using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {
    public Sprite sprite1, sprite2;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start() {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown() {
        //open menu overlay for specific building
    }
}
