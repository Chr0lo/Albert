using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashLeft : MonoBehaviour
{
    public float dashDistance = 5f;
    public float dashDuration = 0.2f;
    public KeyCode dashKey = KeyCode.LeftShift;
    public LayerMask obstacleLayer;

    public Rigidbody2D rb;
    private bool isDashing = false;
    public SpriteRenderer sprite;
    public AudioSource ds;



    private void Update()
    {
        if (Input.GetKeyDown(dashKey) && !isDashing)
        {
            StartCoroutine(onDash());
            ds.Play();
        }
    }

    private IEnumerator onDash()
    {
        isDashing = true;

        Vector3 startPos = transform.position;
        Vector3 dashDirection = Vector3.down;
        if (sprite.flipX)
        {
            dashDirection = Vector3.up;
        }

        Vector3 endPos = startPos + dashDirection * dashDistance;

        float startTime = Time.time;
        while (Time.time < startTime + dashDuration)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, dashDirection, dashDistance, obstacleLayer);
            if (hit.collider != null)
            {
                endPos = hit.point;
                break;
            }

            rb.MovePosition(Vector2.Lerp(startPos, endPos, (Time.time - startTime) / dashDuration));
            yield return null;
        }

        rb.MovePosition(endPos);

        isDashing = false;
    }
}
