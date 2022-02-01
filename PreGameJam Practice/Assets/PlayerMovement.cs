using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Player Movement coded by RudraRaj AKA The_Noobest AKA Mr.Bro.Zone
    //Just changed some variable name
    //Thanks for the code RudraRaj !!!

    public Rigidbody2D Player;
    public float MovementSpeed = 5f;
    public Camera Camera;
    Vector2 Movement;
    Vector2 MousePosition;
    void FixedUpdate()
    {
        Player.MovePosition(Player.position + Movement * MovementSpeed * Time.fixedDeltaTime);

        Vector2 AimDirection = MousePosition - Player.position;
        float AimAngle = Mathf.Atan2(AimDirection.y , AimDirection.x) * Mathf.Rad2Deg - 90f;
        Player.rotation = AimAngle;
    }

    // Update is called once per frame
    void Update()
    {
       Movement.x = Input.GetAxisRaw("Horizontal");
       Movement.y = Input.GetAxisRaw("Vertical");

       MousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
