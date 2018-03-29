using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class girlData : MonoBehaviour {

	//public float speed = 5f;
	float[] dataWomen = new float[56] {0.01f, 0.02f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f, 0.06f, 0.08f, 0.1f, 0.11f, 0.12f, 0.14f, 0.15f, 0.16f, 0.17f, 0.18f, 0.19f, 0.21f, 0.23f, 0.24f, 0.25f, 0.29f, 0.31f, 0.32f, 0.33f, 0.34f, 0.38f, 0.40f, 0.40f, 0.42f, 0.43f, 0.45f, 0.47f, 0.47f, 0.49f, 0.50f, 0.51f, 0.53f, 0.55f, 0.57f, 0.59f, 0.61f, 0.62f, 0.63f, 0.65f, 0.69f, 0.7f, 0.73f, 0.74f, 0.75f, 0.77f, 0.78f, 0.79f, 0.81f, 0.83f};
	Vector3 temp;
	//Vector3 tempPos;
	int counter = 0;
	GameObject DataTextWomen;

	// Use this for initialization
	void Start () {
		DataTextWomen = GameObject.FindGameObjectWithTag ("dataTextWomen");
	}

	// Update is called once per frame
	void Update () {
		//for (int i=0; i<dataWomen.Length; i++){
		/*while (counter <=55){
			//if (tempPos.y >= 0) {
				Debug.Log ("Value of dataWomen[i] = " + dataWomen[counter]);
				temp = transform.localScale;
				temp.y += dataWomen[counter] * Time.deltaTime;
				Debug.Log ("Value of dataWomen = " + temp.y);
				transform.localScale = temp;
				counter++;
				//tempPos = transform.localPosition;
				//tempPos.x = 0;
				//tempPos.y = 0;
				//tempPos.z = 0;
				//transform.localPosition = tempPos;

			//}
		//}
		}*/
		StartCoroutine ("ScaleUp");
	}

	IEnumerator ScaleUp() {
		while (counter <=55){
			Debug.Log ("Value of dataWomen[i] = " + dataWomen[counter]);
			DataTextWomen.GetComponent<Text>().text = "Women: $" + dataWomen [counter];
			temp = transform.localScale;
			temp.y += dataWomen[counter] * 90 * Time.deltaTime;
			Debug.Log ("Value of dataWomen = " + temp.y);
			transform.localScale = temp;
			counter++;
			yield return new WaitForSeconds(50f);
		}
	}
}
