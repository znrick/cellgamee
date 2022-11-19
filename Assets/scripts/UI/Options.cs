using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Toggle fullscreenTog, vsyncTog;

    public List<ResItem> resolutions = new List<ResItem>();
    private int SelectedResolution;

    public Text resolutionLabel;
    // Start is called before the first frame update
    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;

        if (QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        }
        else 
        {
            vsyncTog.isOn = true;
        }

        bool foundRes = false;

        for (int i = 0; i < resolutions.Count; i++)
        {
            if (Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                foundRes = true;
                SelectedResolution = i;
                UpdateResLabel();
            }
        }

        if (!foundRes)
        {
            ResItem newRes = new ResItem();
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;

            resolutions.Add(newRes);
            SelectedResolution = resolutions.Count - 1;

            UpdateResLabel();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResLeft()
    {
        SelectedResolution--;
        if (SelectedResolution < 0)
        {
            SelectedResolution = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
        SelectedResolution++;
        if (SelectedResolution > resolutions.Count - 1)
        {
            SelectedResolution = resolutions.Count - 1;
        }

        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutions[SelectedResolution].horizontal.ToString() + " x " + resolutions[SelectedResolution].vertical.ToString();
    }

    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;

        if (vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else 
        {
            QualitySettings.vSyncCount = 0;
        }

        Screen.SetResolution(resolutions[SelectedResolution].horizontal, resolutions[SelectedResolution].vertical, fullscreenTog.isOn);
    }
    [SerializeField] Slider volumeSlider;

        private void Awake(){
            if (PlayerPrefs.HasKey("Volume")){
                SetVolume(PlayerPrefs.GetFloat("Volume"));
                volumeSlider.value = PlayerPrefs.GetFloat("Volume");
            }
        }

        public void SetVolume(float volume){
            AudioListener.volume = volume;
            PlayerPrefs.SetFloat("Volume", volume);
        }
}
[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}

