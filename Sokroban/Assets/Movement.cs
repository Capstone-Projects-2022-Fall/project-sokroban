using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private bool isMoving;
    private Vector3 originalPosition, targetPosition;
    private float timeToMove = 0.2f;


    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
        }
        if (Input.GetKey("s") && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }
        if (Input.GetKey("d") && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }
        if (Input.GetKey("a") && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }

        transform.position = pos;

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
