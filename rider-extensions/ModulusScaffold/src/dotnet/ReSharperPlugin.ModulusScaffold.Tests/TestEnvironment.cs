﻿using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.ModulusScaffold.Tests
{
    [ZoneDefinition]
    public class ModulusScaffoldTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IModulusScaffoldZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<ModulusScaffoldTestEnvironmentZone> { }

    [SetUpFixture]
    public class ModulusScaffoldTestsAssembly : ExtensionTestEnvironmentAssembly<ModulusScaffoldTestEnvironmentZone> { }
}
