FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ENV DynamoDb_LocalMode='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./TestApi.sln ./
COPY ./TestApi/TestApi.csproj ./TestApi/
COPY ./TestApi.Tests/TestApi.Tests.csproj ./TestApi.Tests/

RUN dotnet restore ./TestApi/TestApi.csproj
RUN dotnet restore ./TestApi.Tests/TestApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out TestApi.Tests/TestApi.Tests.csproj

CMD dotnet test
