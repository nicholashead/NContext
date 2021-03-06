﻿namespace NContext.Tests.Specs.Security.Cryptography
{
    using System;

    using Machine.Specifications;

    public class when_using_salt_base64 : when_hashing_with_HashProvider
    {
        Establish context = () =>
        {
            _TargetPlainText = "NContext";
        };

        Because of = () => _SourceHash = HashProvider.CreateHashToBase64(_TargetPlainText);

        It should_equal_the_base64_value = () => HashProvider.CompareHashFromBase64(_TargetPlainText, _SourceHash).ShouldEqual(true);

        private static String _TargetPlainText;

        private static String _SourceHash;
    }
}