using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Vector3 screenToWorldPointPosition;
	
	GameObject UFO5;
	// Use this for initialization
	void Start () {
		this.UFO5 = GameObject.Find("UFO5");
	}
	
	// Update is called once per frame
	void Update () {

		//マウスの座標に応じてUFOを動かす
		Vector3 mousePosi = Input.mousePosition;

		mousePosi.z = 10.0f;
		
		screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePosi);
	
		UFO5.transform.position = screenToWorldPointPosition;
		
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("tate");
	}
}
