using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasyButton : MonoBehaviour {

	public Button easyButton;

	void Start()
	{
		Button btn = easyButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		Application.LoadLevel("BasicScene");
		StaticClass.CrossSceneInformation = "2";
	}
}
