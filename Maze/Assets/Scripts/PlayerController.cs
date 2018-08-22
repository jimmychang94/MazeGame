using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    private Vector3 movement;

    public float speed;

    public Text winText;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
	}
	
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

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
