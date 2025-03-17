using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject replacementPrefab;
    public MeshRenderer playerMesh;
    public FollowPlayer cameraFollow;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            cameraFollow.enabled = false;
            playerMesh.enabled = false;
            Instantiate(replacementPrefab, transform.position, transform.rotation);
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
