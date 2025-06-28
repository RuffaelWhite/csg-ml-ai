using UnityEngine;

/// <summary>
/// Manages overall game flow, scoring, and achievements.
/// Attach this script to a central GameManager GameObject.
/// </summary>
public class GameManager : MonoBehaviour
{
    public ThreatScore threatScore;

    void Start()
    {
        if (threatScore == null)
        {
            threatScore = FindObjectOfType<ThreatScore>();
        }
        Debug.Log("GameManager initialized.");
    }

    public void AddScoreToRedTeam(int points)
    {
        threatScore.AddRedTeamScore(points);
        CheckAchievements();
    }

    public void AddScoreToBlueTeam(int points)
    {
        threatScore.AddBlueTeamScore(points);
        CheckAchievements();
    }

    void CheckAchievements()
    {
        // TODO: Implement achievement logic based on scores or events
        Debug.Log("Checking achievements...");
    }
}
