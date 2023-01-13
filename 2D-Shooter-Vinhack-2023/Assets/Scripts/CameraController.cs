using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            transform.position = player.transform.position;
        }
    }
}
