using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour {

	void Start()
	{
		Button btn = GetComponent<Button>();
		GameObject.Find("GameObject (1)").GetComponent<BullData>().enabled= false;
		GameObject.Find("GameObject (3)").GetComponent<BullData>().enabled= false;
		GameObject.Find("GameObject").GetComponent<girlData>().enabled= false;
		GameObject.Find("GameObject (2)").GetComponent<girlData>().enabled= false; 
		GameObject.Find("GameObject (4)").GetComponent<ScaleObject>().enabled= true;
		GameObject.Find("First Person Camera").GetComponent<PinchToZoom>().enabled= true;
		btn.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		//if (btn.isClicked)
		GameObject.Find("GameObject (1)").GetComponent<BullData>().enabled= true;
		GameObject.Find("GameObject (3)").GetComponent<BullData>().enabled= true; 
		GameObject.Find("GameObject").GetComponent<girlData>().enabled= true;
		GameObject.Find("GameObject (2)").GetComponent<girlData>().enabled= true;
		GameObject.Find("GameObject (4)").GetComponent<ScaleObject>().enabled= false;
		GameObject.Find("First Person Camera").GetComponent<PinchToZoom>().enabled= false;
		GameObject.Find("ActivateScripts").GetComponent<Image>().enabled= false;
		GameObject.Find("ButtonText").GetComponent<Text>().enabled= false;

	}

}
