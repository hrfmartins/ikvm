﻿using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IKVM.Tests.Java.java.security
{

    [TestClass]
    public class SecurityTests
    {

        [TestMethod]
        public void Can_list_providers()
        {
            var l = global::java.security.Security.getProviders();
            l.Should().HaveCount(8);
        }

    }

}
