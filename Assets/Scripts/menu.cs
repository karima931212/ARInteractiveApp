using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
	public GameObject body;
	public GameObject skeleton;
	public GameObject placenta;
	// Use this for initialization
	void Start () {
		body.SetActive(true);
	}
	
	public void showFullBody()
	{
		if (!body.activeSelf)
		{
			body.SetActive(true);

		}
		else {
			body.SetActive(false);
		}
	}

	public void showSkeleton()
	{
		if (!skeleton.activeSelf)
		{
			skeleton.SetActive(true);

		}
		else
		{
			skeleton.SetActive(false);
		}
	}

	public void showFetus()
	{
		if (!placenta.activeSelf)
		{
			placenta.SetActive(true);

		}
		else
		{
			placenta.SetActive(false);
		}
	}

}
