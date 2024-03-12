using UnityEngine;

public class EraAudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameManager gameManager; 

    private void Start()
    {
       
        PlayAudioForSelectedEra();
    }

    private void PlayAudioForSelectedEra()
    {
        if (gameManager == null)
        {
            Debug.LogError("GameManager não está definido no EraAudioManager.");
            return;
        }


        string audioFileName = GetAudioFileNameForEra(gameManager.selectedEra);

        if (!string.IsNullOrEmpty(audioFileName))
        {
            AudioClip clip = Resources.Load<AudioClip>($"VRTemplateAssets/Audio/Resources/{audioFileName}");
            if (clip != null)
            {
                audioSource.clip = clip;
                audioSource.Play();
            }
            else
            {
                Debug.LogError($"Não foi possível encontrar o arquivo de áudio para a era: {gameManager.selectedEra}");
            }
        }
    }

    private string GetAudioFileNameForEra(TaylorSwiftEra era)
    {
        switch (era)
        {
            case TaylorSwiftEra.Red:
                return "Reputation";
            case TaylorSwiftEra.Reputation:
                return "Reputation";

            default:
                Debug.LogWarning($"Nenhum arquivo de áudio definido para a era: {era}");
                return null;
        }
    }
}