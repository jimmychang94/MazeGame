using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    public float horizontalSpeed = 2.0f;

    private Vector3 offset;

    private float yaw = 0.0f;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}

    private void Update () {
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }

    // Update is called once per frame
    void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
