﻿using AutoMapper;
using Xunit;
using IdentityServer3.Core.Models;
using IdentityServer3.EntityFramework.Entities;
using System.Collections.Generic;

namespace Core.EntityFramework.IntegrationTests
{
    public class AutomapperTests
    {
        [Fact]
        public void AutomapperConfigurationIsValid()
        {
            IdentityServer3.Core.Models.Scope s = new IdentityServer3.Core.Models.Scope()
            {
            };
            var e = s.ToEntity();

            IdentityServer3.EntityFramework.Entities.Scope s2 = new IdentityServer3.EntityFramework.Entities.Scope()
            {
                ScopeClaims = new HashSet<IdentityServer3.EntityFramework.Entities.ScopeClaim>()
            };
            var m = s2.ToModel();

            Mapper.AssertConfigurationIsValid();
        }
    }
}