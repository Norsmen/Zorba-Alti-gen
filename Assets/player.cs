using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float movement_spd = 500f;
    private float movement = 0f;
    public GameObject deadpanel;
    private bool isdead;
    public int skor;
    public Text scoreText;

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isdead)
        {
            Time.timeScale = 0;
            deadpanel.SetActive(true);
        }
        movement = Input.GetAxisRaw("Horizontal");
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;

        }

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * -movement_spd * Time.fixedDeltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isdead = true;
        Time.timeScale = 0;

    }
    
    










}
