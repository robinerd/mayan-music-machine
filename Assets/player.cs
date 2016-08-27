using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    public Vector2 jumpForce;

    float targetX;
    float timeInAir;
    int layerMaskGround;

	// Use this for initialization
	void Start () {
        targetX = transform.position.x;
        timeInAir = 0.0f;
        layerMaskGround = LayerMask.GetMask(new string[] {"Ground"});
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(canJump());

	    if(Input.GetKeyDown(KeyCode.Space) && canJump())
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce, ForceMode2D.Impulse);
        }

        float offsetX = targetX - transform.position.x - GetComponent<Rigidbody2D>().velocity.x;
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * offsetX * 8, ForceMode2D.Force);
	}

    bool canJump()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, layerMaskGround);
        if (hit && hit.collider)
            return true;
        return false;
    }
}
