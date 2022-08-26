< Project Sdk = "Microsoft.NET.Sdk" >

  < PropertyGroup >
    < TargetFramework > net6.0 </ TargetFramework >
    < Nullable > enable </ Nullable >

    < IsPackable > false </ IsPackable >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.NET.Test.Sdk" Version = "16.11.0" />
    < PackageReference Include = "MSTest.TestAdapter" Version = "2.2.7" />
    < PackageReference Include = "MSTest.TestFramework" Version = "2.2.7" />
    < PackageReference Include = "coverlet.collector" Version = "3.1.0" />
  </ ItemGroup >

  < ItemGroup >
    < ProjectReference Include = "..\MoodAnalyzer\Moodanalyzer.csproj" />
  </ ItemGroup >

</Project >