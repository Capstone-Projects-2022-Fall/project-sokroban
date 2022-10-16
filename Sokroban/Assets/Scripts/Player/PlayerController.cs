using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    PhotonView view;

    public float moveSpeed = 10f;
    private bool isMoving;
    private Vector3 originalPosition, targetPosition;
    private float timeToMove = 0.2f;


    void Start() 
    {
        anim = GetComponent<Animator>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Vector3 pos = transform.position;

            //Up
            if (Input.GetKeyDown(KeyCode.W) && !isMoving)
            {
                anim.Play("Up Walk");
                StartCoroutine(MovePlayer(Vector3.up));
            }
            //Down
            if (Input.GetKeyDown(KeyCode.S) && !isMoving)
            {
                anim.Play("Down Walk");
                StartCoroutine(MovePlayer(Vector3.down));
            }
            //Right
            if (Input.GetKeyDown(KeyCode.D) && !isMoving)
            {
                anim.Play("Right Walk");
                StartCoroutine(MovePlayer(Vector3.right));
            }
            //Left
            if (Input.GetKeyDown(KeyCode.A) && !isMoving)
            {
                anim.Play("Left Walk");
                StartCoroutine(MovePlayer(Vector3.left));
            }

            //Idle animations
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.Play("Up Idle");
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                anim.Play("Down Idle");
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                anim.Play("Right Idle");
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                anim.Play("Left Idle");
            }

            transform.position = pos;
        }
    }
    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedTime = 0;
        originalPosition = transform.position;
        targetPosition = originalPosition + direction;

        while(elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(originalPosition, targetPosition, (elapsedTime / timeToMove));
            elapsedTime +=Time.deltaTime;
            yield return null;
        

        }

        transform.position = targetPosition;
        
        isMoving = false;
    }
}
