using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody playerRb; //Assigning rigidbody in Inspector, instead of using GetComponent in Start()
    [SerializeField] float sidewaysForce;
    [SerializeField] float forwardForce;

    void FixedUpdate()
    {
        playerRb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (playerRb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
