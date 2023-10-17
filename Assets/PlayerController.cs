using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private InputController inputController;

    void Awake()
    {
        inputController = new InputController();
    }

    void Start() 
    {
        inputController.Player.Interact.performed += Interact;
    }
  
    public void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Interact");  
    }

    void Update()
    {
        Vector2 inputVector = inputController.Player.Move.ReadValue<Vector2>();
        Vector2 normalizedInputVector = inputVector.normalized;

        Vector3 dir = new Vector3(normalizedInputVector.x, 0f, normalizedInputVector.y);
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    private void OnEnable() 
    {
        inputController.Player.Enable();
    }

    private void OnDisable() 
    {
        inputController.Player.Disable();
    }
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    /*[SerializeField] private float moveSpeed = 2f;
    private InputController inputController;

    void Awake()
    {
        inputController = new InputController();
    }

    void Start() 
    {
        inputController.Player.Interact.performed += Interact;
    }
  
    private void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Interact");  
    }

    void Update()
    {
        Vector2 inputVector = inputController.Player.Move.ReadValue<Vector2>();
        //Vector2 normalizedInputVector = inputVector.normalized;
        Debug.Log(inputVector.magnitude);
        
        Vector3 dir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveSpeed * Time.deltaTime * dir;
    }

    

    
    private void OnEnable() 
    {
        inputController.Player.Enable();
    }

    private void OnDisable() 
    {
        inputController.Player.Disable();
    }*/
}
