using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{

    public GameObject floor;
    public int offset;
    public Transform storage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameObject floorpiece = Instantiate(floor) as GameObject;
            floorpiece.transform.position = new Vector3(transform.position.x + offset, -4.7f, 0);//this is stupid code that the y position of the floor JUST WOULDN'T WORK for, so I manually made the original match the clones.
            floorpiece.transform.SetParent(storage);
        }
    }

    public void ClearStorage()
    {
        int x;
        for(x = 0; x < storage.childCount; x++)
        {
            Destroy(storage.GetChild(x).gameObject);
        }
    }

}
