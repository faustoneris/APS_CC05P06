using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    private Rigidbody2D myBody;

    public float speed = 1f;

    public float minSpeed = 3f;
    public float maxSpeed = 12f;

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        myBody.MovePosition(myBody.position + forward * Time.fixedDeltaTime * speed);
    }
}
