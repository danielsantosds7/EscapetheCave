using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public Animator anim;
    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    public GameObject PlayerMorto;
    public GameObject painelDerrota;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector3(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            anim.enabled = true;
            anim.SetFloat("Horizontal", movementJoystick.joystickVec.x);
            anim.SetFloat("Vertical", movementJoystick.joystickVec.y);
            anim.SetFloat("Speed", movementJoystick.joystickVec.magnitude);
        }
        else
        {
            rb.velocity = Vector3.zero;
            anim.enabled = false;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("enemy"))
        {
            Instantiate(PlayerMorto, transform.position, transform.rotation);
            Destroy(gameObject);
            painelDerrota.SetActive(true);
      
        }
    }
}