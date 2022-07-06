using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int speed = 3;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public static bool schlagfähig;
    public static float SchlagCountdown;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    private void PlayerMovement()
    {
        Vector2 movementVertical = Vector2.zero;
        Vector2 movementHorizontal = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movementHorizontal = Vector2.left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movementVertical = Vector2.up;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementHorizontal = Vector2.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementVertical = Vector2.down;
        }

        transform.Translate(movementHorizontal * speed * Time.deltaTime);
        transform.Translate(movementVertical * speed * Time.deltaTime);
    }

    public static void PlayerKannSchlagen()
    {
        SchlagCountdown -= 1 * Time.deltaTime;

        if (SchlagCountdown <= 0)
        {
            SchlagCountdown = 0;
            schlagfähig = true;
        }
        else
        {
            schlagfähig = false;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
