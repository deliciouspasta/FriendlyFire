using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//失敗
public class SmallGenerator : MonoBehaviour {

	public GameObject smallPrefab;
	float delta = 0;
	float span = 5.0f;
	// Use this for initialization
	void Start () {
		GameObject aaa = Instantiate(smallPrefab) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if(this.delta > this.span){
			this.delta = 0;
			GameObject aaa = Instantiate(smallPrefab) as GameObject;
		}
	}
}
