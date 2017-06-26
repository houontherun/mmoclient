﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIDialogBase : MonoBehaviour {

    public Image Dialog;

    public void ShowProcess()
    {
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.SetActive(true);

        gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        Dialog.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        Dialog.GetComponent<CanvasGroup>().alpha = 0;
        BETween.scale(Dialog.gameObject, 0.2f, new Vector3(0.7f, 0.7f, 0.7f), new Vector3(1, 1, 1)).method = BETweenMethod.easeOutBack;
        BETween.alpha(Dialog.gameObject, 0.2f, 0.0f, 1.0f).method = BETweenMethod.easeOut;
        BETween.alpha(gameObject, 0.2f, 0.0f, 0.5f).method = BETweenMethod.easeOut;
    }

    public void _Hide()
    {
        Time.timeScale = 1;
        BETween.scale(Dialog.gameObject, 0.2f, new Vector3(1, 1, 1), new Vector3(1.3f, 1.3f, 1.3f)).method = BETweenMethod.easeOut;
        BETween.alpha(Dialog.gameObject, 0.2f, 1.0f, 0.0f).method = BETweenMethod.easeOut;
        BETween.alpha(gameObject, 0.2f, 0.5f, 0.0f).method = BETweenMethod.easeOut;
        BETween.enable(gameObject, 0.01f, false).delay = 0.3f;
    }
}
