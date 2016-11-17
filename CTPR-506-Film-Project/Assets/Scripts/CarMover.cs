using UnityEngine;
using System.Collections;

public class CarMover : MonoBehaviour {
    public bool flip = false;
    public float travelSpeed = 5f;
    public float totalDistance = 100f;

    Vector3 startingPosition;
	// Use this for initialization
	void Start () {
        startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (flip) {
            if (transform.position.z > startingPosition.z - totalDistance) {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - travelSpeed * Time.deltaTime);
            } else {
                transform.position = startingPosition;
                randomizeStartSpeed();
            }
        } else {
            if (transform.position.z < startingPosition.z + totalDistance) {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + travelSpeed * Time.deltaTime);
            } else {
                transform.position = startingPosition;
                randomizeStartSpeed();
            }
        }
	}

    void randomizeStartSpeed() {
        travelSpeed += Random.Range(-20, 30);
    }

    public void normalizeSpeed() {
        travelSpeed = 70f;
    }
}
