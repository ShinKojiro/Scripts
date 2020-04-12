using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour
{
    [SerializeField] private HealthControler myHealthController;
    [SerializeField] private PlayerController myPlayerConterller;
    [SerializeField] private int damage;
    [SerializeField] private int heal;

    [SerializeField] private bool damageBool;
    [SerializeField] private bool healBool;

    [SerializeField] private bool speedBoost;
    [SerializeField] private bool jumpBoost;

    [SerializeField] private int boostedSpeed;
    [SerializeField] private int boostedJump;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && damageBool)
        {
            myHealthController.playerHealth = myHealthController.playerHealth - damage;
            myHealthController.UpdateHealth();
        }
        else if (other.CompareTag("Player") && healBool)
        {
            myHealthController.playerHealth = myHealthController.playerHealth + heal;
            myHealthController.UpdateHealth();
        }
        else if(other.CompareTag("player") && speedBoost)
        {
            myPlayerConterller.speed = boostedSpeed;
        }
        else if (other.CompareTag("Player") && jumpBoost)
        {
            myPlayerConterller.jumpForce = boostedJump;
        }
    }
}
