﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {


	public Button quitButton;

	void Start()
	{
		Button btn = quitButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}


	void TaskOnClick()
	{
		Application.Quit();
	}
		
}
