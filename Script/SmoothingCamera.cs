using UnityEngine;
using System.Collections;

public class SmoothingCamera : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    Vector3 targetPosition;
    public float x, y, z;



    Camera camera;
    float shakeAmount = 0.7f;
   public static float shake = 0.3f;
    public float decreaseFactor = 1.0f;



    void Start()
    {
        camera = GetComponent<Camera>();
    }



    void Update()
    {


        if (target.transform.rotation.y > 0)
        {
            
             targetPosition = target.TransformPoint(new Vector3(x, y, z));
        }
        else if (target.transform.rotation.y == 0)
        {
             targetPosition = target.TransformPoint(new Vector3(x, y, -z));
        }
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);



        if (shake > 0)
        {
            camera.transform.localPosition = new Vector3(transform.position.x+ Random.RandomRange(-0.2f,0.2f),transform.position.y+ Random.RandomRange(-0.2f, 0.2f), -z);
            shake -= Time.deltaTime * decreaseFactor;

        }
        else
        {
            shake = 0.0f;
        }

    }
}