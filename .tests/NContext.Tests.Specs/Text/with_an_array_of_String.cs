﻿namespace NContext.Tests.Specs.Text
{
    using System;
    using System.Collections.Generic;

    using FakeItEasy;

    using Machine.Specifications;

    using NContext.Text;

    public class with_an_array_of_String : when_sanitizing_objects_with_ObjectGraphSanitizer
    {
        Establish context = () =>
        {
            TextSanitizer = A.Fake<ISanitizeText>();

            A.CallTo(() => TextSanitizer.SanitizeHtmlFragment(A<string>._))
                .Returns(_SanitizedValue);

            _Data = new String[]
                    {
                        "Daniel",
                        "Gioulakis"
                    };
            };

        Because of = () => Sanitize(_Data);

        It should_sanitize_the_enumerable = () => _Data.ShouldContainOnly(_SanitizedValue, _SanitizedValue);

        static IEnumerable<String> _Data;

        const String _SanitizedValue = "ncontext";
    }
}