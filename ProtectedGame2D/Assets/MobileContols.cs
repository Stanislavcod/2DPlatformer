using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileContols : MonoBehaviour
{
  private AttackController _attackController;
  private PlayerController _playerController;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        _attackController = playerObject.GetComponent<AttackController>();
        _playerController = playerObject.GetComponent<PlayerController>();
    }
    public void Attack()
    {
        _attackController.Attack();  
    }

    public void Jump()
    {
        _playerController.Jump();
    }

    public void Interact()
    {
        _playerController.Interact();
    }
}
