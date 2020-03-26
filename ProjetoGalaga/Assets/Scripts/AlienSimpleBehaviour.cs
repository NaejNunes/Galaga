using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSimpleBehaviour : MonoBehaviour
{
    [SerializeField] protected Animator animatorComponent;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("FlyMove", Random.Range(5, 10));
    }

    protected void FlyMove()
    {
        animatorComponent.SetTrigger("attack");

        Invoke("FlyMove", Random.Range(5, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
