using UnityEngine;
using System.Collections;

public class SpawnObjectTimer : MonoBehaviour {

	public float spawnTime = 5.0f;

	private SpawnObject spawner;

	void Start () {
		spawner = GetComponent<SpawnObject>();
		Invoke( "DoSpawn", spawnTime );
	}

	void DoSpawn () {
		spawner.Spawn();
		Invoke( "DoSpawn", spawnTime );
	}
}