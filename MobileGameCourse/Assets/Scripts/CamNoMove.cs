using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamNoMove : MonoBehaviour
{
    public float offset;
    public Transform playerMoves;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerMoves.position.x+offset, transform.position.y, transform.position.z);
    }
}
