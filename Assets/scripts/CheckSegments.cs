using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSegments : MonoBehaviour {

    GameObject[] segments;
    GameObject winText;

    bool win = true;
    bool ready = false;

	// Use this for initialization
	void Start () {
        segments = GameObject.FindGameObjectsWithTag("Segment");
        winText = GameObject.FindGameObjectWithTag("Win");
        winText.SetActive(false);
        ready = true;
	}
	
	// Update is called once per frame
	void Update () {
        win = true;
        foreach(GameObject segment in segments) {
            if(segment.GetComponent<SegmentScript>().state == false) {
                win = false;
            }
            if(win == false) { break; }
        }
        if (ready) {
            if (win) {
                winText.SetActive(true);
            }
            else {
                winText.SetActive(false);
            }
        }
	}
}
