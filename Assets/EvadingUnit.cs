﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityBaseCode.Steering;

public class EvadingUnit : MonoBehaviour {
	public Steering target;

	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(3f, 12f);
		steering.setSize(0.25f);
		steering.addBehaviour(3f, new WallAvoidance());
		steering.addBehaviour(1f, new Evade(target));
	}
}
