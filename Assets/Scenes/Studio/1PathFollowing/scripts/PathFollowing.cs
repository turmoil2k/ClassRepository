using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    //IMPORTANT = values will declare movement and rots will behave like in the website;
    public Transform[] paths;
    public float speed; // important
    public int smoothRot; //important
    public float reachingDistance;
    public float predictNewPos;
    public int currentPoint = 0;
    Vector3 desired_velo;
    Vector3 steering_velo;
    Vector3 normPosition;
    Vector3 normTarget;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        // Direction Calculation
        Vector3 direction = (paths[currentPoint].position * predictNewPos) - transform.position;
        Vector3 dirNorm = direction.normalized * 15;

        //Movement Controlling
        //rb.AddForce(transform.forward * speed, ForceMode.Force);
        rb.velocity = transform.forward * speed;

        //Rotation Information
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), smoothRot * Time.deltaTime);

        //Destination Information
        if (direction.magnitude <= reachingDistance)
        {
            currentPoint++;
        }

        if (currentPoint >= paths.Length)
        {
            currentPoint = 0;
        }

        //Drawing Rays to display information easier
        Debug.DrawRay(transform.position, dirNorm, Color.blue); // direction 
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green); // forward

        /*
        normPosition = transform.position.normalized;
        normTarget = paths[currentPoint].position.normalized;

        desired_velo = (normTarget - normPosition); //* max_velocity?
        steering_velo = desired_velo - rb.velocity;

        rb.velocity = (rb.velocity + steering_velo);
        transform.position = transform.position + rb.velocity;
        */

        //transform.position += direction * speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, paths[currentPoint].position, Time.deltaTime * speed);
    }








    /*
    void Pursuit()
    {
        //public transform target
        int iterationAhead = 30;

        var targetSpeed = target.gameObject.GetComponent(Move).instantVelocity;

        Vector3 targetFuturePosition = target.transform.position + (targetSpeed * iterationAhead);

        Vector3 direction = targetFuturePosition - transform.position;
        direction.y = 0;



        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);

        int minDistance = 5;
        if (direction.magnitude > minDistance)
        {

            Vector3 moveVector = direction.normalized * speed * Time.deltaTime;

            transform.position += moveVector;
        }
    }
    */
}
