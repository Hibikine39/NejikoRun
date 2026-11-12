using UnityEngine;

public class NejikoHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("“G‚É“–‚½‚Á‚½");
        Destroy(collision.gameObject);
    }
}
