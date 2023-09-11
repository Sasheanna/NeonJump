using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawn : MonoBehaviour
{

    public Transform pos1, pos2;
    public GameObject triangle;

    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(1, 3);

        if (x == 1)
        {
            GameObject Triangle = Instantiate(triangle) as GameObject;
            Triangle.transform.position = pos1.position;
            Triangle.transform.SetParent(transform);
        }

        x = Random.Range(1, 3);

        if(x == 1)
        {
            GameObject Triangle = Instantiate(triangle) as GameObject;
            Triangle.transform.position = pos2.position;
            Triangle.transform.SetParent(transform);
        }

    }

}
