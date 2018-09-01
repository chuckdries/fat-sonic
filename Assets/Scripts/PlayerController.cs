using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
  private Rigidbody rb;
  public int coins;

  // Use this for initialization
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void FixedUpdate()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    // float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

    rb.AddForce(movement * speed);
    // rb.AddForce(this.transform.right * moveHorizontal * speed);
  }

  void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            coins++;
        }
    }

}
