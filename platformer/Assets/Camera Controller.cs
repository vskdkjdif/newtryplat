using UnityEngine;

public class CameraController : MonoBehaviour
{
   Transform playerTransform;
    [SerializeField] Vector3 offset;
    private void Start()
    {
        playerTransform = FindAnyObjectByType<PlayerController>().transform;
        offset = transform.position - playerTransform.position;
    }

    //Update is called once per frame

    private void FixedUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
