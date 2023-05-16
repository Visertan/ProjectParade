using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[Header("Player stats")]

    public float speed = 10f;
    
    public Rigidbody rigidbody;
    Vector3 movement;

    [Space(10)]

    bool canInteract;
    public LayerMask[] interactableObjects;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Interactable")
        {
            Debug.Log("You are in range of an interactable");
            /*if(interactableObjects == "Enemy")
            {
                Debug.Log("You have collided with enemy");
                EnterCombatMenu();
            }*/
        }
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * speed * Time.fixedDeltaTime);
    }

    void EnterCombatMenu()
    {

    }
}
