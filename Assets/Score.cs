using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    private int toku = 0;
    private string ten;
    private bool hit = false;
    private GameObject score;

	// Use this for initialization
	void Start () {
        this.score = GameObject.Find("Score");
		
	}
	
	// Update is called once per frame
	void Update () {
        ten = toku.ToString();
        this.score.GetComponent<Text>().text = ten;

    }

    void OnCollisionEnter(Collision other)
    {
        score.tag = other.gameObject.tag;
           if ( score.tag == "SmallCloudTag")
            {
                toku += 15;
            }
            else if (score.tag == "LargeStarTag")
            {
                toku += 25;
            }
            else if (score.tag == "LargeCloudTag")
            {
                toku += 20;
            }
            else if (score.tag == "SmallStarTag")
            {
                toku += 10;
            }
        }

   }
