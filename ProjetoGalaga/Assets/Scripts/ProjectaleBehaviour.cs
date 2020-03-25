using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectaleBehaviour : MonoBehaviour
{
    [SerializeField] protected float maxDistance;

    protected float speed;
    protected bool move = false;
    protected Vector2 startPosition, direction;
    protected Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Vector2 direction, float speed)
    {
        this.startPosition = transform.position;
        rigidbody.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
