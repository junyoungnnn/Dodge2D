using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Asteroid : MonoBehaviour
{
    [SerializeField] Vector2 direction;
    [SerializeField] Transform playerTransform;
    [SerializeField] float speed = 10.0f;

    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
       
        direction = playerTransform.position - transform.position;

        direction.Normalize();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
