using UnityEngine;

public class BraceletDisplayManager : MonoBehaviour
{
    private const string PrefabsPath = "Bracelets";

    public Transform braceletObjectTransform;

    private void Start()
    {
        InstantiateSelectedBracelet();
    }

    private void InstantiateSelectedBracelet()
    {
        var selectedEra = GameManager.Instance.selectedEra.ToString();
        var selectedPhrase = GameManager.Instance.selectedPhrase;

        string prefabName = selectedEra + "_" + selectedPhrase.Replace(" ", ""); 

        GameObject braceletPrefab = Resources.Load<GameObject>($"{PrefabsPath}/{prefabName}");

        if (braceletPrefab != null)
        {
            GameObject braceletInstance = Instantiate(braceletPrefab, braceletObjectTransform.position, Quaternion.identity);
            braceletInstance.transform.SetParent(braceletObjectTransform, false);

             braceletInstance.transform.localPosition = new Vector3(-20, 150, -20);
            braceletInstance.transform.localRotation = Quaternion.Euler(0, -90, 90);
            braceletInstance.transform.localScale = new Vector3(400, 400, 400);
        }
        else
        {
            Debug.LogError($"Prefab not found for the selected era and phrase: {prefabName}");
        }
    }
}
