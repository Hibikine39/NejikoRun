using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private Transform playerTransfom;

    private Vector3 cameraSetPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraSetPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = new Vector3(playerTransfom.localPosition.x,
                                                   this.transform.localPosition.y,
                                                   playerTransfom.localPosition.z - cameraSetPosition.z);
    }
}
