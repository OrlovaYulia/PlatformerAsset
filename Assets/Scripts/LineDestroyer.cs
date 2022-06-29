using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineDestroyer : MonoBehaviour
{
    public float speed, acceleration;


    void Update()
    {
        speed += acceleration * 0.01f;
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);
        else
            SceneManager.LoadScene(1);
    }
}
