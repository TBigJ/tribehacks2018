using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardButton : MonoBehaviour {

	public Button hardButton;

	void Start()
	{
		Button btn = hardButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Application.LoadLevel("BasicScene");
		StaticClass.CrossSceneInformation = "6";
	}
}
