using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BullData : MonoBehaviour {

	//public float speed = 5f;
	float[] dataMen = new float[55] {0.01f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f, 0.07f, 0.08f, 0.1f, 0.12f, 0.13f, 0.15f, 0.17f, 0.18f, 0.2f, 0.21f, 0.22f, 0.23f, 0.25f, 0.27f, 0.29f, 0.3f, 0.36f, 0.37f, 0.38f, 0.4f, 0.42f, 0.46f, 0.48f, 0.49f, 0.51f, 0.53f, 0.55f, 0.57f, 0.6f, 0.62f, 0.63f, 0.65f, 0.67f, 0.69f, 0.71f, 0.73f, 0.75f, 0.77f, 0.79f, 0.83f, 0.84f, 0.88f, 0.9f, 0.92f, 0.94f, 0.96f, 0.97f, 0.99f, 1f};
	Vector3 temp;
	//Vector3 tempPos;
	int counter = 0;
	GameObject DataTextMen;

	// Use this for initialization
	void Start () {
		DataTextMen = GameObject.FindGameObjectWithTag ("dataText");
	}

	// Update is called once per frame
	void Update () {
		StartCoroutine ("ScaleUp");
	}

	IEnumerator ScaleUp() {
		while (counter <=54){
			Debug.Log ("Value of dataMen[i] = " + dataMen[counter]);
			DataTextMen.GetComponent<Text> ().text = "Men: $" + dataMen [counter];
			if (dataMen [counter] == 1f) {
				DataTextMen.GetComponent<Text> ().color = Color.red;
			}
			temp = transform.localScale;
			temp.y += dataMen[counter] * 90 * Time.deltaTime;
			Debug.Log ("Value of dataMen = " + temp.y);
			transform.localScale = temp;
			counter++;
			yield return new WaitForSeconds(50f);
		}
	}
}
