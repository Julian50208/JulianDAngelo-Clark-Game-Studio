using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUpgrade : MonoBehaviour
{

    [SerializeField] private PlayerController player;
   // [SerializeField] private GameObject item;


    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            player.addJump();
            Destroy(gameObject);
        }
    }


}
