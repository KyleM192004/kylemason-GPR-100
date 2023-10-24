using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class CircleScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float horizontalSpeed;
    public float verticalSpeed;
    public float xInput;
    public float yInput;
    public Score score;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = UnityEngine.Input.GetAxis("Horizontal");
        yInput = UnityEngine.Input.GetAxis("Vertical");

        if(UnityEngine.Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(8);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(xInput * horizontalSpeed, yInput * verticalSpeed);
    }

}
