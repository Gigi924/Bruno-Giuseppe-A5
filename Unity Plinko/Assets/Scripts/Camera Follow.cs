using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    private void FixedUpdate()
    {
        Vector3 targetposition;
        if (disc == null)
        {
            targetposition = player.transform.position;
        }
        else
        {
            targetposition = disc.transform.position;
        }
        targetposition.x = 0;
        targetposition.z = camera.transform.position.z;

        camera.transform.position = Vector3.Lerp(camera.transform.position, targetposition, lerpRate);
    }

    public void FollowDisc(GameObject disc)
    {
        this.disc = disc;
    }

}
