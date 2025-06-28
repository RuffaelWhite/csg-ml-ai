using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages UI interactions for Red and Blue team dashboards.
/// Attach this script to a Canvas GameObject.
/// </summary>
public class UIManager : MonoBehaviour
{
    public Button redAttackButton;
    public Button blueDefendButton;
    public Text redScoreText;
    public Text blueScoreText;

    private ThreatScore threatScore;

    void Start()
    {
        threatScore = FindObjectOfType<ThreatScore>();

        if (redAttackButton != null)
            redAttackButton.onClick.AddListener(OnRedAttack);

        if (blueDefendButton != null)
            blueDefendButton.onClick.AddListener(OnBlueDefend);

        UpdateScoreUI();
    }

    void OnRedAttack()
    {
        Debug.Log("Red Attack button clicked");
        threatScore.AddRedTeamScore(10);
        UpdateScoreUI();
    }

    void OnBlueDefend()
    {
        Debug.Log("Blue Defend button clicked");
        threatScore.AddBlueTeamScore(10);
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (redScoreText != null)
            redScoreText.text = "Red Team Score: " + threatScore.redTeamScore;

        if (blueScoreText != null)
            blueScoreText.text = "Blue Team Score: " + threatScore.blueTeamScore;
    }
}
