using UnityEngine;

public class DestoryBirds : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && enabled)
        {
            Destroy(collision.gameObject);
            ScenceController.Instance.NextLevel();
        }
    }
}
