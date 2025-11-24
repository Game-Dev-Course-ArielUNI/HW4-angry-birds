using System.Collections;
using UnityEngine;

public class Project : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpringJoint2D springJoint2D;
    private bool isPress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        springJoint2D = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPress)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            rb.position = mousePos;

        }
    }

    private void OnMouseDown()
    {
        isPress = true;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnMouseUp()
    {
        isPress = false;
        rb.bodyType = RigidbodyType2D.Dynamic;

        StartCoroutine(Release());
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(0.15f);

        GetComponent<SpringJoint2D>().enabled = false;
    }
}
