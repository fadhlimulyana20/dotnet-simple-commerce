# Use the official ASP.NET Core runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Install EF Core CLI tools (Optional)
RUN dotnet tool install --global dotnet-ef

# Ensure the EF tools are available in the PATH
ENV PATH="${PATH}:/root/.dotnet/tools"

# Copy the csproj and restore as distinct layers
COPY ["dotnet-mvc.csproj", "./"]
RUN dotnet restore "./dotnet-mvc.csproj"

# Copy everything else and build the app
COPY . .
WORKDIR "/src/"
RUN dotnet build "dotnet-mvc.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "dotnet-mvc.csproj" -c Release -o /app/publish

# Build a runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet-mvc.dll"]
