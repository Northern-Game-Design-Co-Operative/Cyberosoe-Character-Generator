using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role
{
    public string role;

    public Role (string role)
    {
        this.role = role;
    }

    public static Role ReturnRandomRole()
    {
        Role randomRole = new Role("pointless talker");
        return randomRole;
    }
}
