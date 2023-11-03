using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon : MonoBehaviour
{
    private bool isWalking = false;
    private bool isRunning = false;
    private bool isRun_Attack = false;
    private bool isWalk_Attack = false;
    private bool isShooting = false;

    void Update()
    {
        // Check for player input
        float moveSpeed = isRunning ? 2f : 1f; // Adjust the speed for running

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);

        if (horizontalInput != 0 || verticalInput != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        if (isWalking && Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else if (isWalking && Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
        }

        if (isWalking && isShooting)
        {
            isWalk_Attack = true;
        }
        else
        {
            isWalk_Attack = false;
        }

        if (isWalking && isRunning && Input.GetKeyDown(KeyCode.V))
        {
            isRun_Attack = true;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            isShooting = true;
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            isShooting = false;
        }
    }
}
