using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetButton("SwitchButton").onClick.AddListener(() =>
		{
			Application.LoadLevel("1");
		});
	}
	
	private Button GetButton(string buttonName)
	{
		GameObject obj = GameObject.Find(buttonName);
		if (obj != null)
		{
			return obj.GetComponent<Button>();
		}
		return null;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
