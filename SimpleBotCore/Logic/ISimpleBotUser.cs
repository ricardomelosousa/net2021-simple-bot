﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBotCore.Logic
{
    public interface ISimpleBotUser
    {
        SimpleUser IdentifyUser(SimpleUser guest);
        string CreateResponse(SimpleUser user, SimpleMessage message);
    }
}
