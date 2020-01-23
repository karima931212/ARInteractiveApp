using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class myButton : MonoBehaviour {
	private int Score;
	private Button btn;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		btn = GetComponent<Button>();
		
        
	}
	void Update() {
		scoreText.text = Score.ToString();

	}

	// Update is called once per frame
	public void AddScore()
	{
		if (btn.interactable) {
            
			Score = Score + 10;
			
			btn.interactable = false;
		}
		
	}
}
