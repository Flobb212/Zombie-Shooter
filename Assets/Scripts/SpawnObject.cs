using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour
{
	public string pooledObjectName = "";
	private Transform mTransform;
	
	void Start ()
	{
		mTransform = transform;
	}
	
	public void Spawn() 
	{
		if( pooledObjectName != "" )
		{
			GameObject g = PoolManager.current.GetPooledObject( pooledObjectName );

			if(pooledObjectName == "Zombie" || pooledObjectName == "FastZombie" || pooledObjectName == "SlowZombie")
			{
				int rand = Random.Range(0,3);
				if(rand == 0)
					pooledObjectName = "Zombie";
				else if (rand == 1)
					pooledObjectName = "FastZombie";
				else
					pooledObjectName = "SlowZombie";
			}

			if( g != null )
			{
				g.transform.position = mTransform.position;
				g.transform.rotation = mTransform.rotation;
				g.SetActive( true );
			}
		}
	}

	public void Drop()
	{
		if (pooledObjectName != "")
		{
			int rand = Random.Range(0,20);
			if (rand == 13)
			{
				int rando = Random.Range(0, 8);
				switch (rando)
				{
				case 0:
					pooledObjectName = "Health Kit";
					break;
				case 1:
					pooledObjectName = "Speed boost";
					break;
				case 2:
					pooledObjectName = "Shield";
					break;
				case 3:
					pooledObjectName = "Assault Rifle";
					break;
				case 4:
					pooledObjectName = "Sniper Rifle";
					break;
				case 5:
					pooledObjectName = "Shotgun";
					break;
				case 6:
					pooledObjectName = "Rocket Launcher";
					break;
				case 7:
					pooledObjectName = "Flame Thrower";
					break;
				}
			}
			GameObject g = PoolManager.current.GetPooledObject (pooledObjectName);

			if( g != null )
			{
				g.transform.position = mTransform.position;
				g.transform.rotation = mTransform.rotation;
				g.SetActive( true );
			}
		}
	}
}