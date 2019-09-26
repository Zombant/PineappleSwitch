using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentScript : MonoBehaviour {

    public int Id;
    public bool state;
    bool tapped;
    bool readyToToggle;
    public bool isLeftEdge;
    public bool isRightEdge;

    ToggleScript toggleScript;
    SpriteRenderer spriteRenderer;

    public Sprite onSprite;
    public Sprite offSprite;
    

	// Use this for initialization
	void Start () {
        toggleScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ToggleScript>();
        spriteRenderer = transform.FindChild("segmentOn").GetComponent<SpriteRenderer>();
        state = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (state) { spriteRenderer.sprite = onSprite; }
        if (!state) { spriteRenderer.sprite = offSprite; }
	}

    void OnMouseOver() {
        //Debug.Log("MOUSE OVER");
        if (Input.GetButtonDown("Fire1")) {
            //Debug.Log("MOUSE DOWN");
            toggleScript.readyToToggle = true;
            toggleScript.Id = Id;
            toggleScript.isLeftEdge = isLeftEdge;
            toggleScript.isRightEdge = isRightEdge;
        }
    }









    public void toggleSegment() {
        if(state) { state = false; }
        else { state = true; }
    }
}
