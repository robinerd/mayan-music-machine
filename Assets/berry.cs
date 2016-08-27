using UnityEngine;
using System.Collections;

public class berry : MonoBehaviour
{
    public bool isEaten = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            //GetComponent<SpriteRenderer>().enabled = false;
            //GetComponent<CircleCollider2D>().enabled = false;
            if(!isEaten)
            {
                isEaten = true;
                Color col = GetComponent<SpriteRenderer>().color;
                col.a = 1.0f;
                GetComponent<SpriteRenderer>().color = col;
                GetComponentInChildren<BerryDisabled>().GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
