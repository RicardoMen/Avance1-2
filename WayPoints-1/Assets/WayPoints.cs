using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    float t = 0;
    int initIndex = 0;
    int endIndex = 1;

    List<Vector3> wayPoint = new List<Vector3>();

    int[][] points = new int[][] {

       new int [] {1, 3}, //0
       new int [] {0,3,4,2}, //1
       new int [] {1, 4}, //2
       new int [] { 4,5}, //3
       new int [] {3, 5}, //4
       new int [] {1, 4,6}, //5
       new int [] {2,5, 4}, //6
       

    };
	void Start () {

        wayPoint.Add(new Vector3(-5.94f, 4.09f));//0
        wayPoint.Add(new Vector3(-5.94f, 1.55f));//1
        wayPoint.Add(new Vector3(-5.94f, -2.009412f));//2
        wayPoint.Add(new Vector3(-2.28f, 3.75f));//3
        wayPoint.Add(new Vector3(-2.12f, -0.29f));//4
        wayPoint.Add(new Vector3(1.84f, 3.71f));//5
        wayPoint.Add(new Vector3(1.75f, -2.009412f));//6

        Next();
    }
	
	void Update () {

            transform.position = Vector3.Lerp(wayPoint[initIndex], wayPoint[endIndex], t);
            t += 0.01f;

        if (t >= 1)
        {
            t = 0;
            Next();
        }
    }

    void Next()
    {
        int vecino = points[endIndex][Random.Range(0,points[endIndex].Length)];

        initIndex = endIndex;
        endIndex = vecino;
        
    }
}
