using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityBaseCode.Steering;

public class PursuingUnit : MonoBehaviour {
	public Steering target;

	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(5f, 16f);
		steering.setSize(0.25f);
		steering.addBehaviour(3f, new WallAvoidance());
		steering.addBehaviour(1f, new Pursue(target));
	}

	void FixedUpdate() {
		if ((target.getPosition() - (Vector2) transform.position).sqrMagnitude < 0.6f * 0.6f) {
			Debug.Log("pursuer reached target!");
			transform.position = new Vector2(Random.Range(-8f,8f), Random.Range(-4f,4f));
		}
	}
}
