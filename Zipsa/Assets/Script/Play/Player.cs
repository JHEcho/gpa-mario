using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;

    /* Collider */
    private BoxCollider2D boxCollider;
    /* Check Collider */
    public LayerMask layerMask;

    

    // Use this for initialization
    void Start () {
        boxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveJoystick();
    }

    void MoveJoystick()
    {
        RaycastHit2D hit;

        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical);

        if (moveVector != Vector3.zero)
        {
            Vector2 currentPosition = transform.position;
            //Vector2 resultPosition = currentPosition + new Vector2((moveVector.x * moveSpeed * (walkSize) / 1000), (moveVector.y * moveSpeed * (walkSize) / 1000));
            Vector2 resultPosition = currentPosition + new Vector2((moveVector.x * moveSpeed * Time.deltaTime), (moveVector.y * (moveSpeed*2) * Time.deltaTime));

            boxCollider.enabled = false;
            hit = Physics2D.Linecast(currentPosition, resultPosition, layerMask);
            boxCollider.enabled = true;

            if(hit.transform == null)
            //Rotation 정보
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
