using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingUnit : MonoBehaviour {
	public List<Vector2> wayPoints = new List<Vector2>();
	private Arrival arrivalBehaviour = new Arrival(Vector2.zero);
	private int nextWayPointIndex = 0;

	void Start () {
		Steering steering = GetComponent<Steering>();
		steering.setSpeed(3f, 12f);
		steering.setSize(0.25f);
		steering.addBehaviour(3f, new WallAvoidance());
		steering.addBehaviour(3f, new UnalignedCollisionAvoidance(steering));
		steering.addBehaviour(1f, arrivalBehaviour);
	}

	void FixedUpdate() {
		Vector2 nextPoint = wayPoints[nextWayPointIndex];
		arrivalBehaviour.setTarget(nextPoint);
		if ((nextPoint - (Vector2) transform.position).sqrMagnitude < 0.1f) {
			nextWayPointIndex = (nextWayPointIndex + 1) % wayPoints.Count;
		}
	}
}
