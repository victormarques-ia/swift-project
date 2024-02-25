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
        var selectedPhrase = GameManager.Instance.selectedPhrase.ToString();

        string prefabName = selectedEra + "_" + selectedPhrase;

        GameObject braceletPrefab = Resources.Load<GameObject>($"{PrefabsPath}/{prefabName}");

        if (braceletPrefab != null)
        {
            GameObject braceletInstance = Instantiate(braceletPrefab, braceletObjectTransform.position, Quaternion.identity);
            braceletInstance.transform.SetParent(braceletObjectTransform, false);

            
            braceletInstance.transform.localPosition = new Vector3(350, -50, -700);
            braceletInstance.transform.localRotation = Quaternion.Euler(-38.549f, 95.402f, -101.025f);
            braceletInstance.transform.localScale = new Vector3(50, 50, 50);
        }
        else
        {
            Debug.LogError($"Prefab not found for the selected era and phrase: {prefabName}");
        }
    }
}
