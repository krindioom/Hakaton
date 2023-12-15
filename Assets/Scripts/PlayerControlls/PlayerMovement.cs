using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bullet; 
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed { get; set; } = 5f;
  //  public event ProjectileEvents.OnSurfaceProjectileHit OnSurfaceHit;


    public float TotalTime = 1f;
    private bool status;
    private float timer = 0;

    private Rigidbody2D _rigidbody;
    private float _xDirection = 0;
    private Shooting _shooting;

    private bool flipped = false;


    // Значение гравитации менять только 1 и -1, 0 не ставить, остальные в принципе всё равно
    // Это сделано, чтоб со стрельбой, да и вообще было проще
    private int gravity = 1;
    private void Awake()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
        _shooting = GetComponent<Shooting>();
        OnSurfaceHit += Teleport;
    }

    private void FixedUpdate()
    {
        Debug.DrawLine(transform.position, (transform.position + Vector3.up), Color.red);
        Move();


       

        if (status)
        {
            timer += Time.deltaTime;
        }
        if (timer > TotalTime)
        {

            status = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !status) 
        {   
            Shoot();
        }

    }

    private void Move()
    {

        _xDirection = Input.GetAxis("Horizontal");

        var motion = new Vector2(_xDirection * Speed, _rigidbody.velocity.y);

        _rigidbody.velocity = motion;
    }
    
    private void Shoot()
    {

        
        _shooting.OnShooting(gravity);
        status = true;
        
    }

    private void Teleport(Bullet sender, Collision2D collision)
    {
        gameObject.transform.position = sender.transform.position - (sender.shoot_dir.normalized * 0.5f);
        if ((collision.collider.CompareTag("Roof") && !flipped) )
        {
            flipped = true;
            GravityFlip();
        }
        if (collision.collider.CompareTag("Surface") && flipped)
        {
            flipped = false;
            GravityFlip();
        }
    }

    private void GravityFlip()
    {
        

        gravity *= -1;
            _rigidbody.gravityScale *= gravity;
            _shooting.FlipShootingPos();
            
    }




}
