using UnityEngine;

public class VRAimLine : MonoBehaviour
{
    public LineRenderer aimLineRenderer;
    public float maxRayDistance = 100.0f;

    private void Awake()
    {
        if (aimLineRenderer == null)
            aimLineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Vector3 endPosition = transform.position + (transform.forward * maxRayDistance);

        if (Physics.Raycast(ray, out hit, maxRayDistance))
        {
            endPosition = hit.point;
        }

        // Defina a posição inicial (0) para a posição do controle e a posição final (1) para o ponto final do raycast
        aimLineRenderer.SetPosition(0, transform.position);
        aimLineRenderer.SetPosition(1, endPosition);
    }
}
