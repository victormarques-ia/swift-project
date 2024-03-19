using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BraceletDisplayManagerMetaQuest : MonoBehaviour
{
    private const string PrefabsPath = "Bracelets";

    public OVRSkeleton skeleton; 
    public int loaded;
    private void Start()
    {
        loaded = 0;
        // InstantiateSelectedBracelet();

    }
    void Update() {
        // Debug.Log("AAAAAAAAAAAAAAAAAA: " + skeleton.Bones.Count);
        if (skeleton.Bones.Count > 0) {
            InstantiateSelectedBracelet();
        }
    }
    private void InstantiateSelectedBracelet()
    {
        var selectedEra = GameManager.Instance.selectedEra.ToString();
        var selectedPhrase = GameManager.Instance.selectedPhrase.ToString().Replace(" ", "");
        // string prefabName = "Evermore_GoldRush";
        string prefabName = selectedEra + "_" + selectedPhrase;
        GameObject braceletPrefab = null;
        if(loaded == 0) {
            braceletPrefab = Resources.Load<GameObject>($"{PrefabsPath}/{prefabName}");
            loaded = 1;
        }
        if (skeleton == null)
        {
            Debug.LogError("Skeleton not found.");
            return;
        }
        if (braceletPrefab != null)
        {

            Debug.Log(skeleton.Bones.Count);
            Debug.Log((int)OVRSkeleton.BoneId.Hand_WristRoot);
            if (skeleton.Bones.Count > (int)OVRSkeleton.BoneId.Hand_WristRoot)
            {
                OVRBone wristBone = skeleton.Bones[(int)OVRSkeleton.BoneId.Hand_WristRoot];

                if (wristBone != null)
                {
                    Transform wristTransform = wristBone.Transform;
                    GameObject braceletInstance = Instantiate(braceletPrefab, wristTransform.position, Quaternion.identity, wristTransform);


                    braceletInstance.transform.localPosition = new Vector3(0f, 0f, 0f);
                    braceletInstance.transform.localRotation = Quaternion.Euler(90, -90, 0);
                    braceletInstance.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
                }
                else
                {
                    Debug.LogError("Wrist bone not found.");
                }
            }
            else
            {
                Debug.LogError("Skeleton does not contain the expected number of bones.");
            }
        }
        else
        {
            Debug.LogError($"Prefab not found for the selected era and phrase: {prefabName}");
        }
    }
}
