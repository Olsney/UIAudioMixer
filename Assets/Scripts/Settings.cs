using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    private const float Coefficiency = 20f;
    
    [SerializeField] private Slider _slider;
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(OnValueChanged);
    }
    
    private void OnValueChanged(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(volume) * Coefficiency);
    }
}
