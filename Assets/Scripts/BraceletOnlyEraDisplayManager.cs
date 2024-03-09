using UnityEngine;

public class BraceletOnlyEraDisplayManager : MonoBehaviour
{
    private const string PrefabsPath = "BraceletsOnlyEra";

    public Transform braceletObjectTransform;

    private void Start()
    {
        InstantiateSelectedEraBracelet();
    }

    private void InstantiateSelectedEraBracelet()
    {
        var selectedEra = GameManager.Instance.selectedEra.ToString();

        string prefabName = selectedEra;

        GameObject braceletPrefab = Resources.Load<GameObject>($"{PrefabsPath}/{prefabName}");

        if (braceletPrefab != null)
        {
            GameObject braceletInstance = Instantiate(braceletPrefab, braceletObjectTransform.position, Quaternion.identity);
            braceletInstance.transform.SetParent(braceletObjectTransform, false);

            braceletInstance.transform.localPosition = new Vector3(-2f, 2, 0);
            braceletInstance.transform.localRotation = Quaternion.Euler(0, -90f, 90);
            braceletInstance.transform.localScale = new Vector3(200, 200, 200);
        }
        else
        {
            Debug.LogError($"Prefab not found for the selected era and phrase: {prefabName}");
        }
    }
}
