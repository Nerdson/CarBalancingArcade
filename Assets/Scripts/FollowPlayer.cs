using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public float smoothing = 6f;
    public Transform lookAtTarget;
    public Transform positionTarget;


    private Vector3 offset = new Vector3(-9, 15, 35);

    public Vector3 Offset { get => offset; set => offset = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.transform.position + Offset;
        transform.rotation = player.transform.rotation;
        transform.LookAt(lookAtTarget);
    }
}
