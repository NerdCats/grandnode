﻿using Grand.Core.Domain.Polls;
using Grand.Web.Models.Polls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grand.Web.Services
{
    public partial interface IPollWebService
    {
        PollModel PreparePoll(Poll poll, bool setAlreadyVotedProperty);
        PollModel PreparePollBySystemName(string systemKeyword);
        List<PollModel> PrepareHomePagePoll();

        void PollVoting(Poll poll, PollAnswer pollAnswer);
    }
}