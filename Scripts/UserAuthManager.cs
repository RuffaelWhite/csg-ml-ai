using UnityEngine;
using System.Collections.Generic;
using System;

/// <summary>
/// Manages user authentication including signup, login, logout, forgot password, and data persistence.
/// Uses PlayerPrefs for simplicity; can be extended to use secure storage or backend.
/// </summary>
public class UserAuthManager : MonoBehaviour
{
    private const string LoggedInUserKey = "LoggedInUser";
    private const string UserDataKeyPrefix = "UserData_";

    public bool IsLoggedIn { get; private set; }
    public string CurrentUser { get; private set; }

    // Simple in-memory user database (username -> password)
    private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

    void Start()
    {
        LoadUser();
        LoadUserDatabase();
    }

    /// <summary>
    /// Registers a new user with username and password.
    /// Returns true if successful, false if username already exists.
    /// </summary>
    public bool Signup(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            Debug.LogWarning("Signup failed: username or password is empty.");
            return false;
        }
        if (userDatabase.ContainsKey(username))
        {
            Debug.LogWarning($"Signup failed: username '{username}' already exists.");
            return false;
        }
        userDatabase[username] = password;
        SaveUserDatabase();
        Debug.Log($"User '{username}' signed up successfully.");
        return true;
    }

    /// <summary>
    /// Logs in a user with username and password.
    /// Returns true if successful.
    /// </summary>
    public bool Login(string username, string password)
    {
        if (IsValidCredentials(username, password))
        {
            CurrentUser = username;
            IsLoggedIn = true;
            SaveUser();
            Debug.Log($"User '{username}' logged in.");
            return true;
        }
        Debug.LogWarning("Invalid login attempt.");
        return false;
    }

    /// <summary>
    /// Logs out the current user.
    /// </summary>
    public void Logout()
    {
        Debug.Log($"User '{CurrentUser}' logged out.");
        CurrentUser = null;
        IsLoggedIn = false;
        PlayerPrefs.DeleteKey(LoggedInUserKey);
    }

    /// <summary>
    /// Resets password for a user if username exists.
    /// Returns true if successful.
    /// </summary>
    public bool ForgotPassword(string username, string newPassword)
    {
        if (userDatabase.ContainsKey(username))
        {
            userDatabase[username] = newPassword;
            SaveUserDatabase();
            Debug.Log($"Password reset for user '{username}'.");
            return true;
        }
        Debug.LogWarning($"Password reset failed: username '{username}' not found.");
        return false;
    }

    private bool IsValidCredentials(string username, string password)
    {
        return userDatabase.ContainsKey(username) && userDatabase[username] == password;
    }

    private void SaveUser()
    {
        PlayerPrefs.SetString(LoggedInUserKey, CurrentUser);
        PlayerPrefs.Save();
    }

    private void LoadUser()
    {
        if (PlayerPrefs.HasKey(LoggedInUserKey))
        {
            CurrentUser = PlayerPrefs.GetString(LoggedInUserKey);
            IsLoggedIn = true;
            Debug.Log($"User '{CurrentUser}' loaded from saved data.");
        }
        else
        {
            IsLoggedIn = false;
            CurrentUser = null;
        }
    }

    private void SaveUserDatabase()
    {
        foreach (var kvp in userDatabase)
        {
            PlayerPrefs.SetString(UserDataKeyPrefix + kvp.Key, kvp.Value);
        }
        PlayerPrefs.Save();
    }

    private void LoadUserDatabase()
    {
        userDatabase.Clear();
        // For simplicity, assume usernames are known or stored elsewhere.
        // Here we load all keys starting with UserDataKeyPrefix.
        foreach (var key in PlayerPrefsKeys())
        {
            if (key.StartsWith(UserDataKeyPrefix))
            {
                string username = key.Substring(UserDataKeyPrefix.Length);
                string password = PlayerPrefs.GetString(key);
                userDatabase[username] = password;
            }
        }
    }

    // Helper to get all PlayerPrefs keys (Unity does not provide this natively)
    private IEnumerable<string> PlayerPrefsKeys()
    {
        // This is a placeholder. In real implementation, maintain a list of keys or use external storage.
        // For demo, return an empty list.
        return new List<string>();
    }

    /// <summary>
    /// Saves user-specific data (e.g., progress) as JSON string.
    /// </summary>
    public void SaveUserData(string jsonData)
    {
        if (!IsLoggedIn) return;
        PlayerPrefs.SetString(UserDataKeyPrefix + CurrentUser + "_Data", jsonData);
        PlayerPrefs.Save();
        Debug.Log($"User data saved for '{CurrentUser}'.");
    }

    /// <summary>
    /// Loads user-specific data as JSON string.
    /// </summary>
    public string LoadUserData()
    {
        if (!IsLoggedIn) return null;
        string key = UserDataKeyPrefix + CurrentUser + "_Data";
        if (PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetString(key);
        }
        return null;
    }
}
