﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:                  Joe Audette
// Created:                 2016-04-23
// Last Modified:           2016-04-29
// 

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NoDb
{
    public interface IGetAllQuery<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(
            string projectId,
            CancellationToken cancellationToken = default(CancellationToken)
            );
    }
}
