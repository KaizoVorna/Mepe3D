using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject replacementPrefab;
    private Mesh playerMesh;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            Instantiate(replacementPrefab, transform.position, transform.rotation);
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
