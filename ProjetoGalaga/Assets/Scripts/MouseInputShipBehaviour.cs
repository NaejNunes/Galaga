using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputShipBehaviour : MonoBehaviour
{
    protected Vector2 nextPosition;
    protected SpriteRenderer spriteRenderer;
    protected Vector3 worldDimension;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        worldDimension = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        nextPosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y);

        if (nextPosition.x < (worldDimension.x - spriteRenderer.size.x / 2) && nextPosition.x > (-worldDimension.x + spriteRenderer.size.x/2))
            transform.position = nextPosition;
    }
}
