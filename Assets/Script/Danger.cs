using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    public float moveSpeed;

    GameController getcore;

    // Start is called before the first frame update
    void Start()
    {
        getcore = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Scene"))
        {
            getcore.scoreUp();
            Destroy(gameObject);
        }

    }

}
