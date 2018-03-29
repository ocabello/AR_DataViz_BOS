using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour {

	public float speed = 0.1f;
	Vector3 objPos;
		void Update()
		{
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				// Get movement of the finger since last frame
				Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

				// Move object across XY plane
			transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, touchDeltaPosition.z * speed);
			}

		/*for (int i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				//Vector3 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				// Create a particle if hit
				//objPos = transform.localPosition;
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit)){
						if (hit.collider != null) {
						   objPos = hit.collider.gameObject.transform.localPosition;
							print ("objPos= " + objPos);
							if (Input.touchCount>0 && Input.GetTouch(i).phase ==TouchPhase.Moved){
							Vector2 touchDeltaPosition = Input.GetTouch(i).deltaPosition;
							//transform.Translate(-ray.direction.x * speed, -ray.direction.y * speed, -ray.direction.z * speed);
							transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
							//Instantiate(particle, transform.position, transform.rotation);
							}
						}
		
				}
			}
		 }*/
		}
}

