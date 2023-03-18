using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelVariants : MonoBehaviour
{
    [SerializeField] private GameObject[] _models;
    private static GameObject _currentSelected;
    [SerializeField] private TMP_Dropdown _dropdown;

    private void Awake()
    {
        _currentSelected = _models[0];
        GetComponent<MaterialManager>().renderer = _currentSelected.GetComponent<Renderer>();

        List<TMP_Dropdown.OptionData> _optionDataList = new List<TMP_Dropdown.OptionData>();
        foreach (var item in _models)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = item.name;
            _optionDataList.Add(data);
        }

        _dropdown.options = _optionDataList;

        _dropdown.onValueChanged.AddListener(Select);
    }

    public void Select(int index)
    {
        _currentSelected.SetActive(false);
        _currentSelected = _models[index];
        GetComponent<MaterialManager>().SetMaterial(GetComponent<MaterialManager>()._currentMaterial);
        GetComponent<MaterialManager>().renderer = _currentSelected.GetComponent<Renderer>();
        _currentSelected.SetActive(true);
    }
}