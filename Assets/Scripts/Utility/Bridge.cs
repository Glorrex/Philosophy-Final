using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    //Create a Referance for the Game Manager
    private GameManager gameManager;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameManager.coins == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            BoxCollider2D col = gameObject.GetComponent<BoxCollider2D>();
            col.isTrigger = false;
        }
    }
}
