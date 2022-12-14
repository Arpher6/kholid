using System.Collections;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movingspeed = 15;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(Vector3.forward * movingspeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.A))
            this.transform.Translate(Vector3.left * movingspeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.S))
            this.transform.Translate(Vector3.back * movingspeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.D))
            this.transform.Translate(Vector3.right * movingspeed * Time.deltaTime, Space.World);
    }
}
