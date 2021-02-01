using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player1Transform;
    public Transform player2Transform;
    private Transform PlayerPosition;

    private void Start()
    {
        PlayerPosition = player1Transform;
    }

    private void Update()
    {
        transform.position = new Vector3(PlayerPosition.position.x, PlayerPosition.position.y, transform.position.z);
    }

    public void switchCamera()
    {
        if(PlayerPosition = player1Transform)
        {
            PlayerPosition = player2Transform;
        }
    }
}
