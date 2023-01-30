using System;
using System.Collections.Generic;

namespace SimplePlatform.Database;

public partial class UserAuthDatum
{
    public string Uid { get; set; } = null!;

    public string AuthToken { get; set; } = null!;

    public string DateOfToken { get; set; } = null!;

    public virtual UserInfo UidNavigation { get; set; } = null!;
}
