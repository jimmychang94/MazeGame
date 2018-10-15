using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    private Vector3 movement;

    public GameObject Camera;

    private float rotation;

    public float speed;

    public Text winText;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
	}
	
	void FixedUpdate ()
    {
        rotation = Camera.transform.eulerAngles.y;

        float move = Input.GetAxis("Vertical");

        if (rotation > 45 && rotation < 125)
        {
            movement = new Vector3(move, 0.0f, 0.0f);
        }
        else if (rotation > 125 && rotation < 225)
        {
            movement = new Vector3(0.0f, 0.0f, -move);
        }
        else if (rotation > 225 && rotation < 315)
        {
            movement = new Vector3(-move, 0.0f, 0.0f);
        }
        else
        {
            movement = new Vector3(0.0f, 0.0f, move);
        }
        rb.AddForce(movement * speed);
	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("WinTrigger"))
        {
            winText.text = "You Win!";
        }
    }
}
