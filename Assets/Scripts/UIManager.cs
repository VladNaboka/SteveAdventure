using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _firstFrame;
    [SerializeField] private GameObject _secondFrame;


    public void SpawnFirstFrame()
    {
        _firstFrame.gameObject.SetActive(true);
    }
    public void SpawnSecondFrame()
    {
        _secondFrame.gameObject.SetActive(true);
    }
}
