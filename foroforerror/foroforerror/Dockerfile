# Use a multi-platform base image for the build stage
FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Rest of your Dockerfile...

# Example: Copy your source code
COPY . .

# Build your application
RUN dotnet publish -c Release -o out

# Use a multi-platform base image for the runtime
FROM --platform=linux/arm64 mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Copy the published output from the build-env stage
COPY --from=build-env /app/out .

# Expose the port
EXPOSE 80

# Set the entry point
ENTRYPOINT ["dotnet", "foroforerror.dll"]
