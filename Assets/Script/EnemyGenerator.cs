using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	// Use this for initialization
	
	public GameObject enemyPrefab;
	float span = 5.0f;
	float delta = 0;
	

	void Start(){
		//GameObject goEnemy = Instantiate(enemyPrefab) as GameObject;
	}
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if(this.delta > this.span){
			this.delta = 0;
			GameObject goEnemy = Instantiate(enemyPrefab) as GameObject;
			int px = Random.Range(-6,7);
			goEnemy.transform.position = new Vector3(px,3,0);
		}
		
	}
}
