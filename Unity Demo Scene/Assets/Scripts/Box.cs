using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    //[SerializeField]
    //private float distance;
    //[SerializeField]
    //private float speed;
    //[SerializeField]
    //private float turnDistance;
    //[SerializeField]
    //private float turnSpeed;
    //[SerializeField]
    //private GameObject directionObject;
    //[SerializeField]
    //private GameObject boxCamera;

    ////private Vector3 currentPosition;
    //private Vector3 futurePosition;
    //private bool moving;
    ////private Quaternion futureAngle;
    //private Vector3 futureAngle;
    //private int direction;
    //private bool setDirection;
    //void Awake()
    //{
    //    //currentPosition = transform.position;
    //    futurePosition = transform.position;
    //    futureAngle = transform.eulerAngles;
    //    directionObject.transform.position = transform.position + transform.forward * turnDistance;
    //    direction = 0;
    //    setDirection = false;
    //    moving = false;
    //    //Debug.Log("Old angle:" + transform.eulerAngles + "New angle:" + futureAngle.eulerAngles);
    //}
    //void FixedUpdate()
    //{
    //    RaycastHit hit;
    //    if (Input.GetKeyDown("j") && !setDirection)
    //    {
    //        //transform.Translate(new Vector3(1, 0, 0));

    //        //futurePosition = currentPosition + new Vector3(distance, 0, 0);
    //        //transform.Translate(Vector3.MoveTowards(currentPosition, futurePosition,speed * Time.deltaTime));
    //        //currentPosition = transform.localPosition;
    //        //Debug.Log("Current position:" + currentPosition + " FuturePosition:" + futurePosition);

    //        //futurePosition = -transform.right * distance;
    //        //StartCoroutine(MoveForward());

    //        futurePosition = transform.position + transform.forward * distance;
    //    }
    //    if (Input.GetKeyDown("k") && !moving)
    //    {
    //        //futureAngle = new Quaternion(transform.eulerAngles.x, transform.eulerAngles.y, turnDistance, transform.eulerAngles.z, 1);
    //        //Debug.Log("Old angle:" + transform.eulerAngles + "New angle:" + futureAngle.eulerAngles);
    //        //transform.LookAt(GameObject.Find("FPSController").transform.position,Vector3.right);
    //        //transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    //        //futureAngle = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + turnDistance, transform.eulerAngles.z);
    //        direction = -1;
    //    }
    //    if (Input.GetKeyDown("l") && !moving)
    //    {
    //        direction = 1;
    //    }
    //    if (!setDirection)
    //    {
    //        directionObject.transform.position = transform.position + transform.forward * turnDistance + transform.right * turnDistance * direction;
    //        if (direction != 0)
    //        {
    //            setDirection = true;
    //        }
    //    }
    //    if (Physics.Raycast(boxCamera.transform.position, transform.forward, out hit))
    //    {
    //        //Debug.Log("Old angle:" + transform.eulerAngles + "New angle:" + futureAngle.eulerAngles);
    //        //Vector3 newDirection = Vector3.RotateTowards(transform.forward, futureAngle.eulerAngles, turnSpeed, 0.0f);
    //        //transform.rotation = Quaternion.LookRotation(newDirection);
    //        //Debug.Log("Old angle:" + transform.eulerAngles + "New angle:" + futureAngle.eulerAngles);
    //        //transform.Rotate(futureAngle);
    //        //transform.eulerAngles = futureAngle;
    //        //transform.LookAt(directionObject.transform);
    //        if (hit.collider.name != directionObject.name)
    //        {
    //            //Vector3 target = directionObject.transform.position - transform.position;
    //            //Vector3 newDirection = Vector3.RotateTowards(Vector3.forward, directionObject.transform.position, speed * Time.deltaTime, 0.0f);
    //            //transform.rotation = Quaternion.LookRotation(newDirection);
    //            //transform.LookAt(directionObject.transform);
    //            Quaternion targetRotation = Quaternion.LookRotation(directionObject.transform.position - transform.position);
    //            float spd = Mathf.Min(speed * Time.deltaTime, 1);
    //            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, spd);
    //        }
    //        else
    //        {
    //            direction = 0;
    //            setDirection = false;
    //        }
    //    }
    //    //Debug.DrawRay(boxCamera.transform.position, transform.forward * turnDistance, Color.red, 1000, false);
    //    if (transform.position != futurePosition)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, futurePosition, speed * Time.deltaTime);
    //        //currentPosition = transform.position;
    //    }
    //    if (Vector3.Distance(transform.position,futurePosition) < 5)
    //    {
    //        moving = true;
    //    }
    //    else
    //    {
    //        moving = false;
    //    }
    //}

    public void DoneMoving()
    {
        GetComponent<Animator>().SetBool("Moving",false);
    }

    //IEnumerator MoveForward()
    //{
    //    while (currentPosition != futurePosition)
    //    {
    //        //transform.Translate(new Vector3(speed, 0, 0));
    //        transform.position = Vector3.MoveTowards(currentPosition, futurePosition, speed * Time.deltaTime);
    //        currentPosition = transform.position;
    //        yield return null;
    //    }
    //}
}
