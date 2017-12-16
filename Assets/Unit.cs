using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(5f, 20f);
		steering.addBehaviour(1f, new Wander());
	}
}
