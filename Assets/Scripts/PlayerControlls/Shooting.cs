using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Vector3 shooting_pos;

    [SerializeField]
    private Transform pfBullet;

    private float posY = 0.5f;


    void FixedUpdate()
    {
        
        shooting_pos = transform.position + new Vector3(0,posY);
    }

    public void OnShooting(int up_or_down)
    {
        Transform bulletTransform = Instantiate(pfBullet, shooting_pos, Quaternion.identity);
        Vector2 shoot_dir = (Vector3.up * up_or_down).normalized;

        bulletTransform.GetComponent<Bullet>().Setup(shoot_dir);
    }
    public void FlipShootingPos(int gravity)
    {
        posY *= gravity;
    }
}
