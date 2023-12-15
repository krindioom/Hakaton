using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

    public event ProjectileEvents.OnSurfaceProjectileHit OnSurfaceHit;

    private Vector3 shoot_dir;
    private float shoot_speed = 10f;
    

    public void Setup(Vector3 _shoot_dir)
    {

        shoot_dir = _shoot_dir;
        transform.eulerAngles = new Vector3(0,0,Utilities.GetAngleFromVectorFloat(shoot_dir));
        Destroy(gameObject,5f);

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Surface"))
    //    {
    //        Debug.Log("Есть контакт!");
    //        OnSurfaceHit?.Invoke(this, collision);
    //    }
    //    if (collision.CompareTag("Mirror"))
    //    {



    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Surface"))
        {
            OnSurfaceHit?.Invoke(this, collision);
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Mirror"))
        {
            shoot_dir = Vector3.Reflect(shoot_dir, collision.GetContact(0).normal);
            
        }
        if (collision.collider.CompareTag("ForceField"))
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        transform.position += shoot_speed * Time.deltaTime * shoot_dir;
        float rotationZ = Utilities.GetAngleFromVectorFloat(shoot_dir);
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }








}
