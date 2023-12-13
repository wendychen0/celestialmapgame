using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineFollowMouse : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public float lineWidth = 0.1f;

    void Start()
    {
        // Ensure the LineRenderer component is attached
        if (lineRenderer == null)
        {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }

        // Set the default properties of the LineRenderer
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
    }

    void Update()
    {
        // Update the line renderer position based on the mouse position
        UpdateLineRendererPosition();
    }

    void UpdateLineRendererPosition()
    {
        // Cast a ray from the camera to the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Perform raycast
        if (Physics.Raycast(ray, out hit))
        {
            // Update the line renderer positions
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, hit.point);
        }
        else
        {
            // If the ray doesn't hit anything, hide the line renderer
            lineRenderer.positionCount = 0;
        }
    }
}
