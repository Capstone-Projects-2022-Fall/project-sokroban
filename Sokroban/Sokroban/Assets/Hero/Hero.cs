using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    private Rigidbody2D body;
    public  Animator anim;
    private float XMovement, YMovement;
    private bool facingRight = true;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //Callin anim once helps preformance, GetComponent too many times slows performance
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        XMovement = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(XMovement, body.velocity.y);
       if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow))
       {
           anim.Play("running");
       }
       if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow))
       {
           anim.Play("Idle");
       }


       if (XMovement < 0 && facingRight)
       {
           flip();
       }
       else if (XMovement > 0 && !facingRight)
       {
           flip();
       }
    }


    public void retry()
    {
        string currecntSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currecntSceneName);
        Debug.Log("Player Respawn");
    }

    private void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
