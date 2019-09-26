using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour {

    public int Id;

    public bool isLeftEdge;
    public bool isRightEdge;

    GameObject[] segments;

    public bool readyToToggle;

    Reset reset;

	// Use this for initialization
	void Start () {
        segments = GameObject.FindGameObjectsWithTag("Segment");
        reset = GetComponent<Reset>();
        reset.resetSegments();
	}
	
	// Update is called once per frame
	void Update () {
		if(readyToToggle){
            toggleSegments();
            readyToToggle = false;
        }
	}

    void toggleSegments() {

        foreach (GameObject segment in segments)
        {
            SegmentScript segmentScript = segment.GetComponent<SegmentScript>();
            int thisId = segmentScript.Id;
            
            if (thisId == Id) {
                segmentScript.toggleSegment();
            }
            if (Id == 0 ) {
                if(thisId == 3 || thisId == 4 || thisId == 2) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 2) {
                if (thisId == 0 || thisId == 1 || thisId == 3) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 4) {
                if (thisId == 0 || thisId == 5 || thisId == 3) {
                    segmentScript.toggleSegment();
                }
            }
            if(Id == 26 && thisId == 31) {
                segmentScript.toggleSegment();
            }
            if (Id == 31) {
                if (thisId == 26 || thisId == 28 || thisId == 33) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 32) {
                if (thisId == 30 || thisId == 28 || thisId == 33) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 28) {
                if (thisId == 27 || thisId == 29 || thisId == 31 || thisId == 32) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 33) {
                if (thisId == 31 || thisId == 32) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 30) {
                if (thisId == 32) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 9 || Id == 14 || Id == 19 || Id == 24 || Id == 29) {
                if(thisId == Id + 1 || thisId == Id - 1 || thisId == Id - 6 || thisId == Id - 4) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 7 || Id == 12 || Id == 17 || Id == 22 || Id == 27) {
                if (thisId == Id + 1 || thisId == Id - 1 || thisId == Id - 6 || thisId == Id - 4) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id != 31 && Id != 32 && Id != 33 && Id != 0 && Id < 26) {
                if (thisId == Id + 5 || thisId == Id - 5) {
                    segmentScript.toggleSegment();
                }
                if (Id == 3 && thisId == 0) {
                    segmentScript.toggleSegment();
                }
                if (Id == 5 && thisId == 0) {
                    segmentScript.toggleSegment();
                }

            }
            if (Id == 3 || Id == 8 || Id == 13 || Id == 18 || Id == 23) {
                if (thisId == Id + 6 || thisId == Id + 4 || thisId == Id - 1 || thisId == Id + 1) {
                    segmentScript.toggleSegment();
                }
            }
            if (isRightEdge) {
                if(thisId == Id + 4 || thisId == Id - 1) {
                    segmentScript.toggleSegment();
                }
            }
            if (isLeftEdge) {
                if(thisId == Id + 1 || thisId == Id + 6) {
                    segmentScript.toggleSegment();
                }
                if(Id == 26 && thisId == 32) {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 31 || Id == 32 || Id == 33 || Id == 0 || Id >= 26) {
                if(Id == 26 && thisId == 21) {
                    segmentScript.toggleSegment();
                }
                if (Id == 31 && thisId == 27) {
                    segmentScript.toggleSegment();
                }
                if (Id == 29) {
                    if (thisId == 24 || thisId == 32) {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 27) {
                    if (thisId == 22 || thisId == 31) {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 28) {
                    if (thisId == 23 || thisId == 33) {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 32 && thisId == 29) {
                    segmentScript.toggleSegment();
                }
                if (Id == 30 && thisId == 25) {
                    segmentScript.toggleSegment();
                }
                if (Id == 33 && thisId == 28) {
                    segmentScript.toggleSegment();
                }
            }
        }
    }

    public void toggleOneSegment(int Id){
        foreach (GameObject segment in segments)
        {
            SegmentScript segmentScript = segment.GetComponent<SegmentScript>();
            int thisId = segmentScript.Id;

            if(Id == 5 || Id == 10 || Id == 15 || Id == 20 || Id == 25 || Id == 30) {
                isRightEdge = true;
            }
            else {
                isRightEdge = false;
            }

            if (Id == 1 || Id == 6 || Id == 11 || Id == 16 || Id == 21 || Id == 26) {
                isLeftEdge = true;
            }
            else {
                isLeftEdge = false;
            }

            if (thisId == Id)
            {
                segmentScript.toggleSegment();
            }
            if (Id == 0)
            {
                if (thisId == 3 || thisId == 4 || thisId == 2)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 2)
            {
                if (thisId == 0 || thisId == 1 || thisId == 3)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 4)
            {
                if (thisId == 0 || thisId == 5 || thisId == 3)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 26 && thisId == 31)
            {
                segmentScript.toggleSegment();
            }
            if (Id == 31)
            {
                if (thisId == 26 || thisId == 28 || thisId == 33)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 32)
            {
                if (thisId == 30 || thisId == 28 || thisId == 33)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 28)
            {
                if (thisId == 27 || thisId == 29 || thisId == 31 || thisId == 32)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 33)
            {
                if (thisId == 31 || thisId == 32)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 30)
            {
                if (thisId == 32)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 9 || Id == 14 || Id == 19 || Id == 24 || Id == 29)
            {
                if (thisId == Id + 1 || thisId == Id - 1 || thisId == Id - 6 || thisId == Id - 4)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 7 || Id == 12 || Id == 17 || Id == 22 || Id == 27)
            {
                if (thisId == Id + 1 || thisId == Id - 1 || thisId == Id - 6 || thisId == Id - 4)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id != 31 && Id != 32 && Id != 33 && Id != 0 && Id < 26)
            {
                if (thisId == Id + 5 || thisId == Id - 5)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 3 && thisId == 0)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 5 && thisId == 0)
                {
                    segmentScript.toggleSegment();
                }

            }
            if (Id == 3 || Id == 8 || Id == 13 || Id == 18 || Id == 23)
            {
                if (thisId == Id + 6 || thisId == Id + 4 || thisId == Id - 1 || thisId == Id + 1)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (isRightEdge)
            {
                if (thisId == Id + 4 || thisId == Id - 1)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (isLeftEdge)
            {
                if (thisId == Id + 1 || thisId == Id + 6)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 26 && thisId == 32)
                {
                    segmentScript.toggleSegment();
                }
            }
            if (Id == 31 || Id == 32 || Id == 33 || Id == 0 || Id >= 26)
            {
                if (Id == 26 && thisId == 21)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 31 && thisId == 27)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 29)
                {
                    if (thisId == 24 || thisId == 32)
                    {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 27)
                {
                    if (thisId == 22 || thisId == 31)
                    {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 28)
                {
                    if (thisId == 23 || thisId == 33)
                    {
                        segmentScript.toggleSegment();
                    }
                }
                if (Id == 32 && thisId == 29)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 30 && thisId == 25)
                {
                    segmentScript.toggleSegment();
                }
                if (Id == 33 && thisId == 28)
                {
                    segmentScript.toggleSegment();
                }
            }
        }
    }

    public void autoSolve()
    {
        foreach(GameObject segment in segments) {
            segment.GetComponent<SegmentScript>().state = true;
        }
    }
}
