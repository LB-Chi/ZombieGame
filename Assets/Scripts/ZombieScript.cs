using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private int speed = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 movementVertical = Vector2.zero;
        Vector2 movementHorizontal = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementHorizontal = Vector2.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementVertical = Vector2.up;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementHorizontal = Vector2.right;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementVertical = Vector2.down;
        }

        transform.Translate(movementHorizontal * speed * Time.deltaTime);
        transform.Translate(movementVertical * speed * Time.deltaTime);
    }
}