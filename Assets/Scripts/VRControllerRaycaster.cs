using UnityEngine;

public class VRControllerRaycaster : MonoBehaviour
{
    public float maxRayDistance = 100.0f;
    public LayerMask interactableLayer;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("PrimaryIndexTrigger");
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawLine(transform.position, transform.position + transform.forward * maxRayDistance, Color.red); // Desenha a linha do raycast

            if (Physics.Raycast(ray, out hit, maxRayDistance, interactableLayer))
            {
                VRButton button = hit.collider.GetComponent<VRButton>();
                if (button != null)
                {
                    button.TriggerButtonAction();
                }
            }
        }
    }
}

public class VRButton : MonoBehaviour
{
    public void TriggerButtonAction()
    {
        Debug.Log("Button action triggered");
        // Implemente a ação do botão aqui
    }
}