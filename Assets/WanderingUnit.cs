using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingUnit : MonoBehaviour {
	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(3f, 12f);
		steering.addBehaviour(3f, new WallAvoidance());
		steering.addBehaviour(1f, new Wander());
	}
}
