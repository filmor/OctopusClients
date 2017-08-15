﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Commands
{
    public interface ISupportFormattedOutput
    {
        Task Query();

        void PrintDefaultOutput();

        void PrintJsonOutput();

        void PrintXmlOutput();
    }
}