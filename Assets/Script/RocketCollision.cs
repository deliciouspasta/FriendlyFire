using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour {

	
	void Start(){
		Debug.Log("aaaaaaaaaaaaaa");
	}
	void OnParticleCollision(GameObject obj){
		if(obj.gameObject.tag == "enemy"){
			Object.Destroy(gameObject);
			Debug.Log("uooooooooooooooooooo");
		}
		
	}

}
