using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Handles UI animations for dashboard panels and alerts.
/// Attach this script to the Canvas or UI panel GameObjects.
/// </summary>
public class UIAnimations : MonoBehaviour
{
    public CanvasGroup redTeamPanel;
    public CanvasGroup blueTeamPanel;
    public CanvasGroup alertPanel;

    void Start()
    {
        // Initialize panels as invisible
        if (redTeamPanel != null) redTeamPanel.alpha = 0f;
        if (blueTeamPanel != null) blueTeamPanel.alpha = 0f;
        if (alertPanel != null) alertPanel.alpha = 0f;

        // Start fade-in animations
        if (redTeamPanel != null) StartCoroutine(FadeIn(redTeamPanel));
        if (blueTeamPanel != null) StartCoroutine(FadeIn(blueTeamPanel));
    }

    IEnumerator FadeIn(CanvasGroup canvasGroup)
    {
        float duration = 1f;
        float elapsed = 0f;
        while (elapsed < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 1f;
    }

    public void ShowAlert(string message)
    {
        if (alertPanel != null)
        {
            // TODO: Display alert message text
            StartCoroutine(FadeIn(alertPanel));
            // Optionally add fade-out after delay
        }
    }
}
