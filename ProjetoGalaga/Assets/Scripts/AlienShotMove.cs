using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShotMove : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected float projectileSpeed;

    protected GameObject projectileTemp;

    public void missileShoot()
    {
        projectileTemp = Instantiate(projectilePrefab);
        projectileTemp.transform.position = transform.position;
        projectileTemp.GetComponent<ProjectaleBehaviour>().Shoot(Vector2.down, projectileSpeed);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
