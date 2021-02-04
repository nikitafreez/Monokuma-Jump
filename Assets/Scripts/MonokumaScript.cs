using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonokumaScript : MonoBehaviour
{
    public static MonokumaScript instance;

    float horizontal;
    public Rigidbody2D RigidBody;
    public Transform ballPos;
    public Text BestScore;
    
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
        BestScore.text = $"Score: {UIScript.instance.scoreMax}";
    }


    void Update()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (transform.position.x > 3f)
        {
            transform.position = new Vector3(transform.position.x - (3f*2), transform.position.y);
        }
        if (transform.position.x < -3f)
        {
            transform.position = new Vector3(transform.position.x + (3f*2), transform.position.y);
        }

        RigidBody.velocity = new Vector2(Input.acceleration.x * 10f, RigidBody.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "KillBox")
        {
            SceneManager.LoadScene(0);
        }
    }
}
