﻿using NextGen.Application.Common.Interfaces;
using System;

namespace NextGen.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
