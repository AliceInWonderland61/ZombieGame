using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon : MonoBehaviour
{// Define your boolean parameters
  Animator animator;
    int isWalkingHash;
    int isRunningHash;

    Rigidbody rigidbody;

        public float rotationSpeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        isWalkingHash=Animator.StringToHash("isWalking");
        isRunningHash=Animator.StringToHash("isRunning");
        rigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
 void FixedUpdate()
    {
    bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPress = Input.GetKey(KeyCode.W);
        bool backwardPress = Input.GetKey(KeyCode.S);
        bool leftPress = Input.GetKey(KeyCode.A);
        bool rightPress = Input.GetKey(KeyCode.D);
        bool runPress = Input.GetKey(KeyCode.LeftShift);

        // Set isWalking based on whether the player is pressing any movement keys.
        animator.SetBool(isWalkingHash, forwardPress || backwardPress || leftPress || rightPress);

        // Set isRunning based on whether the player is pressing the run key and is also walking.
        animator.SetBool(isRunningHash, runPress && isWalking);

        // Rotate the player based on the movement keys that are pressed.
        if (leftPress)
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
        if (rightPress)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        // Move the player based on the movement keys that are pressed.
        Vector3 movement = Vector3.zero;
        if (forwardPress)
        {
            movement += Vector3.forward;
        }
        if (backwardPress)
        {
            movement += Vector3.back;
        }

        if (movement != Vector3.zero)
        {
            // Move the player in the direction of movement.
            float speed = isRunning ? 10f : 5f;
            rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        }
    }

}
