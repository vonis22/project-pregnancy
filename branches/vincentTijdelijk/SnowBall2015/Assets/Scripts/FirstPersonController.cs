using UnityEngine;
using System.Collections;

/* TO DO:
 * Lower StrafeSprintspeed Somehow
*/
[RequireComponent (typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {

	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 2.0f;
	public float upDownRange = 60.0f;
	public float jumpSpeed = 5.0f;
	float verticalRotation = 0.0f;
	bool canDoubleJump = false;
	bool sprint;

	float verticalVelocity = 0.0f;

	CharacterController characterController;
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		characterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		// FPS LookHorizontal

		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);
		//FPS LookVertical
		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);
	
		//Character movement

		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float strafeSpeed = Input.GetAxis ("Horizontal") * (movementSpeed-2);

		verticalVelocity += Physics.gravity.y * Time.deltaTime;

						if (Input.GetButtonDown ("Jump") && characterController.isGrounded) {
						verticalVelocity = jumpSpeed;
						canDoubleJump = true;

		} 
		if (Input.GetButtonDown ("Jump") && canDoubleJump && characterController.isGrounded == false) {
			verticalVelocity = (jumpSpeed + 1);
			canDoubleJump = false;

				}
		Debug.Log (canDoubleJump);
				
		Vector3 speed = new Vector3 (strafeSpeed, verticalVelocity, forwardSpeed);

		speed = transform.rotation * speed;
		

		characterController.Move( speed *Time.deltaTime);


		//Sprinting Handler
		if (sprint) {
			movementSpeed = 10.0f;
		
				}
		else {
			movementSpeed = 5.0f;
		}
		if (Input.GetKey(KeyCode.LeftShift)) {
			sprint = true;
				}
		else {
			sprint = false;
		}
	}
}
