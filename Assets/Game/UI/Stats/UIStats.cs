using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStats : MonoBehaviour
{
    private static UIStats instance;
    public static UIStats Instance => instance;

    [SerializeField] private Slider[] StatSliders;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void SetSliderValue(int index, int value)
    {
        StatSliders[index].value = value;
    }

    public void SetSliderMax(int index, int max)
    {
        StatSliders[index].maxValue = max;
    }





}
