using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	private int Score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore()
	{

		Score = Score + 10;
		scoreText.text = Score.ToString();
	}
}
