using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Implements role-based access control (RBAC) with least privilege principles.
/// </summary>
public class RoleBasedAccessControl : MonoBehaviour
{
    private Dictionary<string, List<string>> rolePermissions = new Dictionary<string, List<string>>();

    void Start()
    {
        InitializeRoles();
    }

    void InitializeRoles()
    {
        // Define roles and their permissions
        rolePermissions["Admin"] = new List<string> { "Read", "Write", "Delete", "Configure" };
        rolePermissions["User"] = new List<string> { "Read", "Write" };
        rolePermissions["Guest"] = new List<string> { "Read" };
        Debug.Log("Roles and permissions initialized.");
    }

    public bool HasPermission(string role, string permission)
    {
        if (rolePermissions.ContainsKey(role))
        {
            return rolePermissions[role].Contains(permission);
        }
        return false;
    }
}
