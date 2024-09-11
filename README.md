# MSTest Issues Demo

## Build error when one test project references another

Starting with MSTest 3.6.0, when one test project references another test project, warning CS0436 is emitted by the
compiler because the same type is being compiled into two assemblies.

### Steps to reproduce

- Checkout `build-error-on-reference` branch
- Run `dotnet clean` to ensure a clean environment
- Run `dotnet build`

### Expected Results

The build command is successful.

### Actual Results

The build command fails with the following error:

```
I:\code\MSTestDemo\ProjectTwo.Tests\obj\Debug\net8.0\TestPlatformEntryPoint.cs(13,9): warning CS0436: The type 'SelfRegi
steredExtensions' in 'I:\code\MSTestDemo\ProjectTwo.Tests\obj\Debug\net8.0\AutoRegisteredExtensions.cs' conflicts with t
he imported type 'SelfRegisteredExtensions' in 'ProjectOne.Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
. Using the type defined in 'I:\code\MSTestDemo\ProjectTwo.Tests\obj\Debug\net8.0\AutoRegisteredExtensions.cs'. [I:\code
\MSTestDemo\ProjectTwo.Tests\ProjectTwo.Tests.csproj]
```

## No/empty TRX file generated from `dotnet test`

There are no TRX result files generated when using `dotnet test`, though there are with `dotnet vstest`.

### Steps to reproduce

- Checkout `dotnet-test-trx` branch
- Run `dotnet clean` to ensure a clean environment
- Run `dotnet test --logger trx --results-directory dotnet-test-results`
- Run `dotnet vstest **/*.Tests.dll /Logger:trx /ResultsDirectory:dotnet-vstest-results`

### Expected Results

Both `dotnet-test-results` and `dotnet-vstest-results` folders are created with a `.trx` file with details of the test
run.

### Actual Results

Only `dotnet-vstest-results` is created with a `.trx` file.
