using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaController : MonoBehaviour {

	GameObject ec;
	GameObject UFO5;
	ParticleSystem particle;
	float span = 1.0f;
	float delta = 0;
	bool isInterval = true;
	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem>();
		particle.Stop();
		this.ec = GameObject.Find("UFOEnemy");
		this.UFO5 = GameObject.Find("UFO5");
	}
	
	public void Plasmame(){
		particle.Play();
	}
	// Update is called once per frame
	void Update () {
	
		Vector2 p1 = this.ec.transform.position;
		Vector2 p2 = this.UFO5.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		if(d <= 0.5){
			particle.Play();
			
		}
		this.delta += Time.deltaTime;
		if(this.delta > span){
			this.delta = 0;
			particle.Stop();
			
		}
	}
}
