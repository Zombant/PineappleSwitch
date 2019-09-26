using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public int numOfCycles;

    ToggleScript toggleScript;

    bool canContinue = false;

	// Use this for initialization
	void Start () {
        toggleScript = GetComponent<ToggleScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void resetSegments() {
        for(int i = 0; i < numOfCycles; i++) {
            toggleScript.toggleOneSegment(Random.Range(1, 33));
        }
    }

    
}
