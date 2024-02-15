using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    float speed = 3f;
    Rigidbody2D rb;
    public Button buttun;
    public CamMove cam;
    public Text Score;
    float count = 0f;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        buttun.onClick.AddListener(() => Gravety());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp;
        temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    void Gravety()
    {
        float Grav = rb.gravityScale;
        Grav *= -1;
        rb.gravityScale = Grav;
        Vector3 scale;
        scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;
    }
    void OnCollisionEnter2D(Collision2D target)
    { 
        if (target.gameObject.tag == "Rocket")
        {
            Destroy(target.gameObject);
            cam.enabled = false;
            transform.position = new Vector2(transform.position.x, 100);
            StartCoroutine(RestartGame());
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Coin")
        {
            Destroy(target.gameObject);
            count++;
            Score.text = count.ToString();
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


















}
