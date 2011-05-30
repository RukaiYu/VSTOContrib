﻿using System;
using System.Collections.Generic;
using FacebookToOutlook.Core;

namespace FacebookToOutlook.Data
{
    public interface IFacebookRepository
    {
        IList<FacebookEvent> GetEvents();
        IList<FacebookEvent> GetModifiedEvents(DateTime since);
        IList<long> GetDeletedEventIds();
    }
}