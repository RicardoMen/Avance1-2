using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	List<Vector3> path = new List<Vector3>();
	int currentIndex = -1;
	float t = 0;

	void Start()
	{
			path.Add(new Vector3(0, 0));
			path.Add(new Vector3(3, 3));
			path.Add(new Vector3(5, 1));
			path.Add(new Vector3(4, -3));
			path.Add(new Vector3(4, 4));
			path.Add(new Vector3(0, 0));

			NextPoint();
	}
	
	void Update()
	{
		transform.position = Vector3.Lerp(path[currentIndex], path[currentIndex + 1], t);
		t += 0.01f;

		if (t >= 1)
		{
			t = 0;
			NextPoint();
		}
	}

	void NextPoint()
	{
		currentIndex++;
		if (currentIndex == path.Count - 1) currentIndex = 0;
	}
}
