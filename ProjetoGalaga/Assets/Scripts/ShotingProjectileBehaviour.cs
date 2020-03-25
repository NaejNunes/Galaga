using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotingProjectileBehaviour : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected float projectileSpeed;

    protected GameObject projectileTemp;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            projectileTemp = Instantiate(projectilePrefab);
            projectileTemp.transform.position = transform.position;
            projectileTemp.GetComponent<ProjectaleBehaviour>().Shoot(Vector2.up, projectileSpeed);
        }
    }
}
