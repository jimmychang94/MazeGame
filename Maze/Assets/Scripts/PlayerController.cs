using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    private Vector3 movement;

    public GameObject Camera;

    public GameObject EndMenu;

    private float rotation;

    public float speed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
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
            EndMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
