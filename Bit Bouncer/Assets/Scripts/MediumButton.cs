using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MediumButton : MonoBehaviour {

	public Button mediumButton;

	void Start()
	{
		Button btn = mediumButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Application.LoadLevel("BasicScene");
		StaticClass.CrossSceneInformation = "8";
	}
}
