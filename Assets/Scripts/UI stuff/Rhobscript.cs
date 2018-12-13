using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhobscript : MonoBehaviour {

    private Transform target;

    [Header("Attributes")]


    public float range = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;


    [Header("Unity setup fields")]

    //public Transform rotatetri;
    public float turnSpeed = 10f;
    public string enemyTag = "Enemy";


    public GameObject bulletPrefab;
    public GameObject bulletPrefabtwo;
    public Transform firePoint;
    public Transform firePointtwo;




    // Use this for initialization
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);


    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (target == null)
            return;



        //  Vector3 dir = target.position - transform.position;
        // Quaternion lookRotation = Quaternion.LookRotation(dir);
        //  Vector3 rotation = Quaternion.Lerp(rotatetri.rotation,lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        // rotatetri.rotation = Quaternion.Euler(0f,0f,rotation.z);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;


    }

    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GameObject bulletGOtwo = (GameObject)Instantiate(bulletPrefabtwo,firePointtwo.position, firePointtwo.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();
        Bulletwo bullettwo = bulletGOtwo.GetComponent<Bulletwo>();

        if (bullet != null)
            bullet.Seek(target);

        if (bullettwo != null)
            bullettwo.Seek(target);


    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
