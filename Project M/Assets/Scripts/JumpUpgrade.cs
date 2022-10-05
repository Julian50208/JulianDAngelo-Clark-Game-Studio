using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUpgrade : MonoBehaviour
{

    [SerializeField] private PlayerController player;

    private void Start()
    {

    }

    private void OnCollisionEnter()
    {
  
        player.addJump();
        gameObject.active = false;

    }


}
