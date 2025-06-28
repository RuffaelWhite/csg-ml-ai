using UnityEngine;

/// <summary>
/// Manages scoring, alerts, and defense success metrics.
/// Attach this script to a GameObject managing the game state.
/// </summary>
public class ThreatScore : MonoBehaviour
{
    public int redTeamScore = 0;
    public int blueTeamScore = 0;

    public void AddRedTeamScore(int points)
    {
        redTeamScore += points;
        Debug.Log("Red Team Score: " + redTeamScore);
    }

    public void AddBlueTeamScore(int points)
    {
        blueTeamScore += points;
        Debug.Log("Blue Team Score: " + blueTeamScore);
    }

    // TODO: Add methods for alerts and defense success tracking
}
