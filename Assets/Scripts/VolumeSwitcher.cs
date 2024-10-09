using UnityEngine;
using UnityEngine.UI;

public class VolumeSwitcher : MonoBehaviour
{
    [SerializeField] private AudioSource[] _audioSources;
    [SerializeField] private Button _button;

    private bool isTurnedOn;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }
    
    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        isTurnedOn = !isTurnedOn;
        
        SwitchVolumeState();
    }

    private void SwitchVolumeState()
    {
        foreach (var audioSource in _audioSources)
        {
            audioSource.mute = isTurnedOn;
        }
    }
}