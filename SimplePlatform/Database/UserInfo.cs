using System;
using System.Collections.Generic;

namespace SimplePlatform.Database;

public partial class UserInfo
{
    public string Name { get; set; } = null!;

    public string? Surname { get; set; }

    public string? Dateofbirth { get; set; }

    public string Email { get; set; } = null!;

    public string Uid { get; set; } = null!;

    public string Dateofregistration { get; set; } = null!;

    public virtual UserAuthDatum? UserAuthDatum { get; set; }
}
