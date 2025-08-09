using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelMain : MonoBehaviour, IMenu
{
    [SerializeField] private eLevelMode levelMode;

    [SerializeField] private Button playBtn;

    private UIMainManager m_mngr;

    private void Awake()
    {
        playBtn.onClick.AddListener(OnClickMoves);
        //btnTimer.onClick.AddListener(OnClickTimer);
    }

    private void OnDestroy()
    {
        if (playBtn) playBtn.onClick.RemoveAllListeners();
        //if (btnTimer) btnTimer.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }


    private void OnClickMoves()
    {
        m_mngr.LoadLevel(levelMode);
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
