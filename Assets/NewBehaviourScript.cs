
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject target;
    public float movingSpeed = 2f;
    public float turnSpeed = 0.05f;
    // Update is called once per frame
    void Update()
    {
        Vector3 gapPosition = target.transform.position - this.transform.position;
        gapPosition = new Vector3(gapPosition.x, 0, gapPosition.z);
        Quaternion lookRotation = Quaternion.LookRotation(gapPosition);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, lookRotation, turnSpeed);
        this.transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
    }
}
