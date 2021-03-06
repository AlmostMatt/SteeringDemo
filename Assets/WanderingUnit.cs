﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityBaseCode.Steering;

public class WanderingUnit : MonoBehaviour {
	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(3f, 12f);
		steering.setSize(0.25f);
		steering.addBehaviour(3f, new WallAvoidance());
		steering.addBehaviour(1f, new Wander());
		steering.addBehaviour(3f, new UnalignedCollisionAvoidance(steering));
	}
}
