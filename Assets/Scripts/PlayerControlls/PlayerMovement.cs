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

    private float  TotalTime = 1f;
    private float timer = 0;
    private bool status;
    

    private Rigidbody2D _rigidbody;
    private float _xDirection = 0;
    private Shooting _shooting;

    private bool flipped = false;


    // Значение гравитации менять только 1 и -1, 0 не ставить, остальные в принципе всё равно
    // Это сделано, чтоб со стрельбой, да и вообще было проще
    private int gravity = 1;
    private void Start()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
        _shooting = GetComponent<Shooting>();
        OnSurfaceHit += Teleport;
    }

    private void FixedUpdate()
    {
        Debug.DrawLine(transform.position, (transform.position + Vector3.up), Color.red);
        


        if (status)
        {
            timer -= Time.fixedDeltaTime;
            if (timer <= 0)
            {
                timer = 0;
                status = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.E) && !status) 
        {   
            Shoot();
            timer = TotalTime;
            status = true;
        }
        Move();
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
        
        
    }

    private void Teleport(Bullet sender, Collision2D collision)
    {
        gameObject.transform.position = sender.transform.position - (sender.shoot_dir.normalized * 0.5f);
        if (collision.collider.CompareTag("Roof"))
        {
            flipped = true;
            GravityFlip(-1);
        }
        if (collision.collider.CompareTag("Surface"))
        {
            flipped = false;

            
        }
    }

    private void GravityFlip(int _gravity)
    {
        

            gravity *= _gravity;
            _rigidbody.gravityScale *= _gravity;
            _shooting.FlipShootingPos(_gravity);
            
    }




}
