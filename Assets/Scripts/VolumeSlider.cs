using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{

    [SerializeField] private AudioMixer _audioMixer;
    private Slider _volumeSlider;
    [SerializeField] private string _volumeParameter;

    void Awake()
    {
        _volumeSlider = GetComponent<Slider>();
        _volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }
    void Start()
    {

    }

    void ChangeVolume(float value)
    {
        _audioMixer.SetFloat(_volumeParameter, Mathf.Log10(value) * 20);
    }
}
