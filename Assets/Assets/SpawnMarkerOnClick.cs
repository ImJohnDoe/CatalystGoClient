using UnityEngine;
using System.Collections;

public class SpawnMarkerOnClick : MonoBehaviour {
	public GameObject marker;

	// Update is called once per frame
	void Update () {
		

		if(Input.GetMouseButtonDown(0)) {
			Ray position = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (position, out hit, 100000)){
				
				Instantiate(marker, hit.point , Quaternion.LookRotation(Vector3.up));
		
			}
	}
}
}