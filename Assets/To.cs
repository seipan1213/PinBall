using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class To : MonoBehaviour {

    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;
    private float flickAngle = -20;

    Touch tch;
    Vector3 tap;
	// Use this for initialization
	void Start () {
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                tap = touch.position;
            }
            if (tap.x < 0 && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }

            if (tap.x >= 0 && tag == "RightFripperTag") 
            {
                SetAngle(this.flickAngle);
            }
        }
        if (Input.touchCount > 0)
        {
            SetAngle(this.defaultAngle);
        }
    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }

}
