using UnityEngine;
using System.Collections;

public class CarTrigger : MonoBehaviour {
    public CarMover[] movers;
	
    void OnTriggerEnter(Collider other) {
        for(int i = 0; i < movers.Length; i++) {
            movers[i].normalizeSpeed();
        }
    }
}
