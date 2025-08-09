using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelGame : MonoBehaviour,IMenu
{
    public Text LevelConditionView;

    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnAutoPlay;
    [SerializeField] private Button btnAutoLose;

    private UIMainManager m_mngr;

    private void Awake()
    {
        btnPause.onClick.AddListener(OnClickPause);
        btnAutoPlay.onClick.AddListener(OnClickAutoPlay);
    }

    private void OnClickPause()
    {
        m_mngr.ShowPauseMenu();
    }
    private void OnClickAutoPlay()
    {
        m_mngr.ToggleAutoPlay();
    } 

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
