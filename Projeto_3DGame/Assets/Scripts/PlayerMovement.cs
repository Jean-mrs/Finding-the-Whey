using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 5;
	public Rigidbody rb;
	public float horizontalMultiplier = 2;

	float horizontalInput;

    // Update is called once per frame

    private void FixedUpdate ()
    {
    	Vector3 forwardMove =transform.forward * speed * Time.fixedDeltaTime;
    	Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
    	rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
