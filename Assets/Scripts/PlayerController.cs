using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
  public Rigidbody rb;
  public GameObject cube;
  public int coins;

  private Vector3 cubeOffset;

  void Start()
  {
    cubeOffset = cube.transform.position - rb.transform.position;
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

  void LateUpdate()
  {
    cube.transform.position = rb.transform.position + cubeOffset;
  }

  public void OnChildTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            coins++;
        }
    }

}
