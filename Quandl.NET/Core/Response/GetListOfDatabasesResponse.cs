﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quandl.NET.Core.Response
{
    public class GetListOfDatabasesResponse
    {
        public GetListOfDatabasesResponse(List<DatabaseMetadata> databases, Meta meta)
        {
            Databases = databases;
            Meta = meta;
        }

        public List<DatabaseMetadata> Databases { get; private set; }

        public Meta Meta { get; private set; }
    }
}
